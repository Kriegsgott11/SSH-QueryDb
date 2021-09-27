using SSH_QueryDb.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSH_QueryDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Settings();
        }

        private void Load_Settings()
        {
            TxtSSHHost.Text = Properties.Settings.Default.SSHHost;
            TxtSSHPort.Text = Properties.Settings.Default.SSHPort;
            TxtSSHUser.Text = Properties.Settings.Default.SSHUser;
            TxtSSHPassword.Text = Properties.Settings.Default.SSHPass;
            TxtSQLHost.Text = Properties.Settings.Default.SQLHost;
            TxtSQLIPA.Text = Properties.Settings.Default.SQLIPA;
            TxtSQLPort.Text = Properties.Settings.Default.SQLPort;
            TxtConnectionString.Text = Properties.Settings.Default.SQLConnectionString;
            TxtCommandQuery.Text = Properties.Settings.Default.SQLCommandQuery;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Settings();
        }

        private void Save_Settings()
        {
            Properties.Settings.Default.SSHHost = TxtSSHHost.Text;
            Properties.Settings.Default.SSHPort = TxtSSHPort.Text;
            Properties.Settings.Default.SSHUser = TxtSSHUser.Text;
            Properties.Settings.Default.SSHPass = TxtSSHPassword.Text;
            Properties.Settings.Default.SQLHost = TxtSQLHost.Text;
            Properties.Settings.Default.SQLIPA = TxtSQLIPA.Text;
            Properties.Settings.Default.SQLPort = TxtSQLPort.Text;
            Properties.Settings.Default.SQLConnectionString = TxtConnectionString.Text;
            Properties.Settings.Default.SQLCommandQuery = TxtCommandQuery.Text;

            Properties.Settings.Default.Save();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                Save_Settings();

                ConnectonSettings settings = new ConnectonSettings
                {
                    SSHHost = TxtSSHHost.Text,
                    SSHPort = int.Parse(TxtSSHPort.Text),
                    SSHUser = TxtSSHUser.Text,
                    SSHPass = TxtSSHPassword.Text,
                    SQLHost = TxtSQLHost.Text,
                    SQLIPA = TxtSQLIPA.Text,
                    SQLPort = int.Parse(TxtSQLPort.Text),
                    SQLConnectionString = TxtConnectionString.Text,
                    SQLCommandQuery = TxtCommandQuery.Text
                };

                SSHHelper ssh = new SSHHelper(settings);

                ssh.ExecuteCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
