using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CCTV_Monitoring
{
    public partial class MainForm : Form
    {
        public static bool EditConnection = false;

        private static List<AppCheckAlertRequest> LocalDbContainer = new List<AppCheckAlertRequest>();
        private static List<AppCheckAlertRequest> ServerDbContainer = new List<AppCheckAlertRequest>();

        int TotalSeconds = 0;
        int Minutes = 0;
        int Seconds = 0;

        public MainForm()
        {
            InitializeComponent();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Location.txt"))
            {
                string[] connectionString = File.ReadAllLines("Location.txt");

                txt_location.Text = connectionString[0];
            }

            pictureBox_Loading.SizeMode = PictureBoxSizeMode.StretchImage;

            lbl_running.Visible = false;
            lbl_stop.Visible = false;

            if (!File.Exists("DbConnection.txt"))
            {
                ConnectionForm cf = new ConnectionForm();
                cf.ShowDialog();
            }

            if (string.IsNullOrEmpty(txt_location.Text)) { return; }

            StartSending_To_Server();
            //this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectionStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm cf = new ConnectionForm();
            cf.Show();
            EditConnection = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartSending_To_Server();
        }

        private void StartSending_To_Server()
        {
            StreamWriter sw = new StreamWriter("Location.txt");
            //Write a line of text
            sw.WriteLine(txt_location.Text);
            //Close the file
            sw.Close();

            if (string.IsNullOrEmpty(txt_location.Text))
            {
                MessageBox.Show("Warning!! Location must not be empty.");
                return;
            }
            SwitchButtonEnabled();

            //GetAllDataFromServer();

            Thread mainThread = Thread.CurrentThread;
            //Thread Proceso1 = new Thread(ProcessSendingToServer);
            //Proceso1.IsBackground = true;
            //Proceso1.Start();

            TotalSeconds = 60 * int.Parse(cbox_minutes.Text);

            ResetTime();

            pictureBox_Loading.Visible = true;
            delayTimer.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            SwitchButtonEnabled();
            ResetTime();
            delayTimer.Stop();
        }

        private void delayTimer_Tick(object sender, EventArgs e)
        {

            ProcessSendingToServer();
        }

        //Continues running
        private void ProcessSendingToServer()
        {
            if (Minutes <= -1)
            {
                //MessageBox.Show("App Will restart");
                delayTimer.Stop();
                SwitchButtonEnabled();
                ResetTime();
                StartSending_To_Server();
            }
            Seconds -= 1;
            lbl_countDownTime.Text = $"{Minutes}:{Seconds} sec before Sending...";

            if (Seconds <= 0)
            {

                if (Minutes == 0 && Seconds == 0)
                {
                    // Check if the device is connected to the internet
                    if (!IsConnectedToInternet())
                    {
                        lbl_pleaseWait.Visible = false;
                        lbl_running.Visible = true;

                        ResetTime();
                        return; 
                    }

                    lbl_pleaseWait.Visible = true;
                    lbl_running.Visible = false;

                    var t = Task.Run(async delegate
                    {
                        await Task.Delay(100);
                        return 42;
                    });
                    t.Wait();

                    var x = Task.Run(async delegate
                    {

                        GetAllDataFromServer();
                        await Task.Delay(1000);
                        return 42;
                    });
                    x.Wait();
                    try
                    {
                        LocalDbContainer = DbConnection.GetAppChecks().Result;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check your database connection credentials.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        SwitchButtonEnabled();
                        ResetTime();
                        delayTimer.Stop();
                    }
                    foreach (var localAppCheck in LocalDbContainer)
                    {
                        var serverAppCheck = ServerDbContainer.Find(x =>
                            x.Name.ToLower() == localAppCheck.Name.ToLower() &&
                            x.Location.ToLower() == txt_location.Text.ToLower() &&
                            x.Host == localAppCheck.Host);

                        if (serverAppCheck != null)
                        {

                            if (localAppCheck.Status != serverAppCheck.Status)
                            {
                                localAppCheck._id = serverAppCheck._id;
                                //Send Update to Server
                                APIRequester.Update_CCTV_Status(localAppCheck, serverAppCheck._id);

                                rtb_dataLogs.AppendText("Logs(Update)-> " +
                                    $"Id: {localAppCheck.Id}, " +
                                    $"Name: {localAppCheck.Name}, " +
                                    $"TimeOut= {localAppCheck.TimeOut}, " +
                                    $"Ping: ({localAppCheck.Host}), " +
                                    $"Status: {localAppCheck.Status}, " +
                                    $"Location: {txt_location.Text}, " +
                                    Environment.NewLine);
                            }
                        }
                        else
                        {
                            localAppCheck.Location = txt_location.Text;
                            // import new data in online server
                            APIRequester.SendCCTV_Status(localAppCheck);
                            rtb_dataLogs.AppendText("Logs(Import)-> " +
                                    $"Id: {localAppCheck.Id}, " +
                                    $"Name: {localAppCheck.Name}, " +
                                    $"TimeOut= {localAppCheck.TimeOut}, " +
                                    $"Ping: ({localAppCheck.Host}), " +
                                    $"Status: {localAppCheck.Status}, " +
                                    $"Location: {txt_location.Text}, " +
                                    Environment.NewLine);
                        }

                    }

                    lbl_pleaseWait.Visible = false;
                    lbl_running.Visible = true;

                    ResetTime();
                    //delayTimer.Stop();
                }
                else
                {
                    Minutes -= 1;
                    Seconds = 60;
                }
            }
        }

        public bool IsConnectedToInternet()
        {
            string host = "bubble.io";  
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch 
            {
                var w = new Form() { Size = new Size(0, 0) };
                Task.Delay(TimeSpan.FromSeconds(5))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

                MessageBox.Show(w, "Please make sure you have internet connection.", "Connection Failed.");
            }
            return result;
        }
        private void ResetTime()
        {
            Minutes = int.Parse(cbox_minutes.Text) - 1;
            Seconds = 60;
        }
        private void SwitchButtonEnabled()
        {
            if (btn_start.Enabled == true)
            {
                lbl_running.Visible = true;
                lbl_stop.Visible = false;

                btn_start.Enabled = false;
                btn_stop.Enabled = true;
            }
            else
            {
                lbl_running.Visible = false;
                lbl_stop.Visible = true;

                btn_start.Enabled = true;
                btn_stop.Enabled = false;
            }
        }

        private void GetAllDataFromServer()
        {
            ServerDbContainer.Clear();
            var cursor = 0;
            var count = 100;
            for (var i = 0; i < 100; i++)
            {
                //Get All Data From Server
                var response = APIRequester.GetAll_CCTV_Status(cursor, count,txt_location.Text);
                if (response.results.Count == 0)
                {
                    break;
                }

                ServerDbContainer.AddRange(response.results);

                cursor += response.count;
                count = response.remaining;
                
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }


        //private delegate void GenericDelegate();


        //private void StartThread()
        //{
        //    //
        //    Thread.Sleep(3000);

        //    //Where i process the search

        //    // Then periodically if you want to update a picture, I.e. an animation...
        //    Invoke(new GenericDelegate(UpdatePictureBox));

        //    // Then when finished, consider invoking a method to hide the picture box.
        //    Invoke(new GenericDelegate(HidePictureBox));


        //}
        //private void UpdatePictureBox()
        //{
        //    MessageBox.Show("here");


        //}

        //private void HidePictureBox()
        //{
        //    pictureBox_Loading.Visible = false;
        //}

        //private void btn_startThread_Click(object sender, EventArgs e)
        //{
        //    pictureBox_Loading.Visible = true;
        //    Thread th = new Thread(new ThreadStart(StartThread));
        //    th.IsBackground = true;
        //    th.Start();
        //}

    }
}