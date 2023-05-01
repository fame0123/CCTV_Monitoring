using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTV_Monitoring
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
        private delegate void GenericDelegate();


        private void StartThread()
        {
            //
            Thread.Sleep(3000);

            //Where i process the search

            // Then periodically if you want to update a picture, I.e. an animation...
            Invoke(new GenericDelegate(UpdatePictureBox));

            // Then when finished, consider invoking a method to hide the picture box.
            pbIndicator.Visible = false;
            //Invoke(new GenericDelegate(HidePictureBox));


        }
        private void UpdatePictureBox()
        {
            MessageBox.Show("here");
            

        }

        private void HidePictureBox()
        {
            pbIndicator.Visible = false;
        }

        private void btn_startThread_Click(object sender, EventArgs e)
        {
            pbIndicator.Visible = true;
            Thread th = new Thread(new ThreadStart(StartThread));
            th.IsBackground = true;
            th.Start();
        }
        //public static string UrlEncode(string strname, System.Text.Encoding e);
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = System.Web.HttpUtility.UrlEncode(textBox1.Text);
        }
    }
}
