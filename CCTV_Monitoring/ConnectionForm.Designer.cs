
namespace CCTV_Monitoring
{
    partial class ConnectionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_saveConnection = new System.Windows.Forms.Button();
            this.btn_cancelConnection = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dbName = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_testConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_saveConnection
            // 
            this.btn_saveConnection.Location = new System.Drawing.Point(283, 266);
            this.btn_saveConnection.Name = "btn_saveConnection";
            this.btn_saveConnection.Size = new System.Drawing.Size(75, 36);
            this.btn_saveConnection.TabIndex = 5;
            this.btn_saveConnection.Text = "Save";
            this.btn_saveConnection.UseVisualStyleBackColor = true;
            this.btn_saveConnection.Click += new System.EventHandler(this.btn_saveConnection_Click);
            // 
            // btn_cancelConnection
            // 
            this.btn_cancelConnection.Location = new System.Drawing.Point(202, 266);
            this.btn_cancelConnection.Name = "btn_cancelConnection";
            this.btn_cancelConnection.Size = new System.Drawing.Size(75, 36);
            this.btn_cancelConnection.TabIndex = 6;
            this.btn_cancelConnection.Text = "Cancel";
            this.btn_cancelConnection.UseVisualStyleBackColor = true;
            this.btn_cancelConnection.Click += new System.EventHandler(this.btn_cancelConnection_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(117, 184);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(241, 27);
            this.txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(117, 219);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(241, 27);
            this.txt_password.TabIndex = 4;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(117, 148);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(160, 27);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "app_checks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Database Connection Setup";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Db Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_dbName
            // 
            this.txt_dbName.Location = new System.Drawing.Point(117, 113);
            this.txt_dbName.Name = "txt_dbName";
            this.txt_dbName.Size = new System.Drawing.Size(241, 27);
            this.txt_dbName.TabIndex = 1;
            this.txt_dbName.Text = "nmon";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(117, 75);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(241, 27);
            this.txt_host.TabIndex = 0;
            this.txt_host.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Host:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_testConnection
            // 
            this.btn_testConnection.Location = new System.Drawing.Point(12, 267);
            this.btn_testConnection.Name = "btn_testConnection";
            this.btn_testConnection.Size = new System.Drawing.Size(148, 35);
            this.btn_testConnection.TabIndex = 7;
            this.btn_testConnection.Text = "Test Connection";
            this.btn_testConnection.UseVisualStyleBackColor = true;
            this.btn_testConnection.Visible = false;
            this.btn_testConnection.Click += new System.EventHandler(this.btn_testConnection_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 313);
            this.Controls.Add(this.btn_testConnection);
            this.Controls.Add(this.btn_cancelConnection);
            this.Controls.Add(this.btn_saveConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.txt_dbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Connection String";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_saveConnection;
        private System.Windows.Forms.Button btn_cancelConnection;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dbName;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_testConnection;
    }
}

