using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTV_Monitoring
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("DbConnection.txt"))
            {
                string[] connectionString = File.ReadAllLines("DbConnection.txt");

                txt_host.Text = connectionString[0];
                txt_dbName.Text = connectionString[1];
                txt_port.Text = connectionString[2];
                txt_username.Text = connectionString[3];
                txt_password.Text = connectionString[4];
            }
        }

        private void btn_saveConnection_Click(object sender, EventArgs e)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("DbConnection.txt");
                //Write a line of text
                sw.WriteLine(txt_host.Text);
                //Write a second line of text
                sw.WriteLine(txt_dbName.Text);
                //Write a second line of text
                sw.WriteLine(txt_port.Text);
                //Write a second line of text
                sw.WriteLine(txt_username.Text);
                //Write a second line of text
                sw.WriteLine(txt_password.Text);
                //Close the file
                sw.Close();

                MessageBox.Show("Connection string has been saved!");

                this.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine("Exception: " + x.Message);
            }
        }

        private void btn_cancelConnection_Click(object sender, EventArgs e)
        {
            if (File.Exists("DbConnection.txt"))
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btn_testConnection_Click(object sender, EventArgs e)
        {

        }
    }
}
