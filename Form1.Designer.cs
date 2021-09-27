
namespace SSH_QueryDb
{
    partial class Form1
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
            this.TxtSSHHost = new System.Windows.Forms.TextBox();
            this.TxtSSHPort = new System.Windows.Forms.TextBox();
            this.TxtSSHUser = new System.Windows.Forms.TextBox();
            this.TxtSSHPassword = new System.Windows.Forms.TextBox();
            this.TxtSQLHost = new System.Windows.Forms.TextBox();
            this.TxtSQLIPA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSQLPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCommandQuery = new System.Windows.Forms.TextBox();
            this.TxtConnectionString = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSSHHost
            // 
            this.TxtSSHHost.Location = new System.Drawing.Point(195, 40);
            this.TxtSSHHost.Name = "TxtSSHHost";
            this.TxtSSHHost.Size = new System.Drawing.Size(335, 20);
            this.TxtSSHHost.TabIndex = 0;
            // 
            // TxtSSHPort
            // 
            this.TxtSSHPort.Location = new System.Drawing.Point(195, 66);
            this.TxtSSHPort.Name = "TxtSSHPort";
            this.TxtSSHPort.Size = new System.Drawing.Size(335, 20);
            this.TxtSSHPort.TabIndex = 1;
            // 
            // TxtSSHUser
            // 
            this.TxtSSHUser.Location = new System.Drawing.Point(195, 92);
            this.TxtSSHUser.Name = "TxtSSHUser";
            this.TxtSSHUser.Size = new System.Drawing.Size(335, 20);
            this.TxtSSHUser.TabIndex = 2;
            // 
            // TxtSSHPassword
            // 
            this.TxtSSHPassword.Location = new System.Drawing.Point(195, 118);
            this.TxtSSHPassword.Name = "TxtSSHPassword";
            this.TxtSSHPassword.Size = new System.Drawing.Size(335, 20);
            this.TxtSSHPassword.TabIndex = 3;
            // 
            // TxtSQLHost
            // 
            this.TxtSQLHost.Location = new System.Drawing.Point(195, 157);
            this.TxtSQLHost.Name = "TxtSQLHost";
            this.TxtSQLHost.Size = new System.Drawing.Size(335, 20);
            this.TxtSQLHost.TabIndex = 6;
            // 
            // TxtSQLIPA
            // 
            this.TxtSQLIPA.Location = new System.Drawing.Point(195, 183);
            this.TxtSQLIPA.Name = "TxtSQLIPA";
            this.TxtSQLIPA.Size = new System.Drawing.Size(335, 20);
            this.TxtSQLIPA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "SSH Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SSH Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SSH User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SSH Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SQL Host";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "SQL IPA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "SQL Port";
            // 
            // TxtSQLPort
            // 
            this.TxtSQLPort.Location = new System.Drawing.Point(195, 209);
            this.TxtSQLPort.Name = "TxtSQLPort";
            this.TxtSQLPort.Size = new System.Drawing.Size(335, 20);
            this.TxtSQLPort.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "SQL Command Query";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "SQL Connection String";
            // 
            // TxtCommandQuery
            // 
            this.TxtCommandQuery.Location = new System.Drawing.Point(195, 261);
            this.TxtCommandQuery.Multiline = true;
            this.TxtCommandQuery.Name = "TxtCommandQuery";
            this.TxtCommandQuery.Size = new System.Drawing.Size(335, 63);
            this.TxtCommandQuery.TabIndex = 19;
            // 
            // TxtConnectionString
            // 
            this.TxtConnectionString.Location = new System.Drawing.Point(195, 235);
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.Size = new System.Drawing.Size(335, 20);
            this.TxtConnectionString.TabIndex = 18;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(256, 353);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 22;
            this.BtnExecute.Text = "Execute Command";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 388);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCommandQuery);
            this.Controls.Add(this.TxtConnectionString);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSQLPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSQLIPA);
            this.Controls.Add(this.TxtSQLHost);
            this.Controls.Add(this.TxtSSHPassword);
            this.Controls.Add(this.TxtSSHUser);
            this.Controls.Add(this.TxtSSHPort);
            this.Controls.Add(this.TxtSSHHost);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSSHHost;
        private System.Windows.Forms.TextBox TxtSSHPort;
        private System.Windows.Forms.TextBox TxtSSHUser;
        private System.Windows.Forms.TextBox TxtSSHPassword;
        private System.Windows.Forms.TextBox TxtSQLHost;
        private System.Windows.Forms.TextBox TxtSQLIPA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSQLPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCommandQuery;
        private System.Windows.Forms.TextBox TxtConnectionString;
        private System.Windows.Forms.Button BtnExecute;
    }
}

