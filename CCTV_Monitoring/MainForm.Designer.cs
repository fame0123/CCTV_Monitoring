
namespace CCTV_Monitoring
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.rtb_dataLogs = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_running = new System.Windows.Forms.Label();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_countDownTime = new System.Windows.Forms.Label();
            this.cbox_minutes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Loading = new System.Windows.Forms.PictureBox();
            this.lbl_pleaseWait = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_start.Location = new System.Drawing.Point(12, 141);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(256, 57);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Enabled = false;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_stop.ForeColor = System.Drawing.Color.Red;
            this.btn_stop.Location = new System.Drawing.Point(12, 204);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(256, 57);
            this.btn_stop.TabIndex = 0;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // rtb_dataLogs
            // 
            this.rtb_dataLogs.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_dataLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_dataLogs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_dataLogs.HideSelection = false;
            this.rtb_dataLogs.Location = new System.Drawing.Point(289, 60);
            this.rtb_dataLogs.Name = "rtb_dataLogs";
            this.rtb_dataLogs.Size = new System.Drawing.Size(579, 373);
            this.rtb_dataLogs.TabIndex = 1;
            this.rtb_dataLogs.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStringToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectionStringToolStripMenuItem
            // 
            this.connectionStringToolStripMenuItem.Name = "connectionStringToolStripMenuItem";
            this.connectionStringToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.connectionStringToolStripMenuItem.Text = "Edit Connection";
            this.connectionStringToolStripMenuItem.Click += new System.EventHandler(this.connectionStringToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_running
            // 
            this.lbl_running.AutoSize = true;
            this.lbl_running.BackColor = System.Drawing.Color.Transparent;
            this.lbl_running.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_running.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_running.Location = new System.Drawing.Point(83, 406);
            this.lbl_running.Name = "lbl_running";
            this.lbl_running.Size = new System.Drawing.Size(90, 27);
            this.lbl_running.TabIndex = 3;
            this.lbl_running.Text = "Running";
            // 
            // lbl_stop
            // 
            this.lbl_stop.AutoSize = true;
            this.lbl_stop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stop.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_stop.ForeColor = System.Drawing.Color.Red;
            this.lbl_stop.Location = new System.Drawing.Point(785, 28);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(83, 32);
            this.lbl_stop.TabIndex = 3;
            this.lbl_stop.Text = "Stop";
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 1000;
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // lbl_countDownTime
            // 
            this.lbl_countDownTime.AutoSize = true;
            this.lbl_countDownTime.BackColor = System.Drawing.Color.Transparent;
            this.lbl_countDownTime.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_countDownTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_countDownTime.Location = new System.Drawing.Point(289, 30);
            this.lbl_countDownTime.Name = "lbl_countDownTime";
            this.lbl_countDownTime.Size = new System.Drawing.Size(86, 25);
            this.lbl_countDownTime.TabIndex = 3;
            this.lbl_countDownTime.Text = "00:00 sec";
            // 
            // cbox_minutes
            // 
            this.cbox_minutes.BackColor = System.Drawing.Color.LightGray;
            this.cbox_minutes.FormattingEnabled = true;
            this.cbox_minutes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbox_minutes.Location = new System.Drawing.Point(211, 96);
            this.cbox_minutes.Name = "cbox_minutes";
            this.cbox_minutes.Size = new System.Drawing.Size(57, 28);
            this.cbox_minutes.TabIndex = 4;
            this.cbox_minutes.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes beffore send:";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(104, 63);
            this.txt_location.Multiline = true;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(164, 27);
            this.txt_location.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location:";
            // 
            // pictureBox_Loading
            // 
            this.pictureBox_Loading.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Loading.Image = global::CCTV_Monitoring.Properties.Resources.load3;
            this.pictureBox_Loading.Location = new System.Drawing.Point(39, 267);
            this.pictureBox_Loading.Name = "pictureBox_Loading";
            this.pictureBox_Loading.Size = new System.Drawing.Size(184, 166);
            this.pictureBox_Loading.TabIndex = 6;
            this.pictureBox_Loading.TabStop = false;
            this.pictureBox_Loading.Visible = false;
            // 
            // lbl_pleaseWait
            // 
            this.lbl_pleaseWait.AutoSize = true;
            this.lbl_pleaseWait.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pleaseWait.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_pleaseWait.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pleaseWait.Location = new System.Drawing.Point(65, 406);
            this.lbl_pleaseWait.Name = "lbl_pleaseWait";
            this.lbl_pleaseWait.Size = new System.Drawing.Size(135, 27);
            this.lbl_pleaseWait.TabIndex = 3;
            this.lbl_pleaseWait.Text = "Pleases wait...";
            this.lbl_pleaseWait.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "This app monitor the status of camera.";
            this.notifyIcon1.BalloonTipTitle = "CCTV Monitoring App";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.cbox_minutes);
            this.Controls.Add(this.lbl_stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_countDownTime);
            this.Controls.Add(this.lbl_running);
            this.Controls.Add(this.rtb_dataLogs);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_pleaseWait);
            this.Controls.Add(this.pictureBox_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTV Monitoring v3.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RichTextBox rtb_dataLogs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_running;
        private System.Windows.Forms.Label lbl_stop;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.Label lbl_countDownTime;
        private System.Windows.Forms.ComboBox cbox_minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Loading;
        private System.Windows.Forms.Label lbl_pleaseWait;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}