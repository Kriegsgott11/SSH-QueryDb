using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSH_QueryDb.Class
{
    public class SSHHelper
    {
        private readonly ConnectonSettings _settings;

        public SSHHelper(ConnectonSettings settings)
        {
            _settings = settings;
        }

        public void ExecuteCommand()
        {
            PasswordConnectionInfo connectionInfo =
                new PasswordConnectionInfo(_settings.SSHHost, _settings.SQLPort, _settings.SSHUser, _settings.SSHPass)
                {
                    Timeout = TimeSpan.FromSeconds(30)
                };

            using (var client = new SshClient(connectionInfo))
            {
                try
                {
                    client.Connect();
                    if (!client.IsConnected)
                    {
                        MessageBox.Show("SSH connection failed.");
                        return;
                    }

                    var PortFwdL = new ForwardedPortLocal(_settings.SQLIPA, (uint)_settings.SQLPort, _settings.SQLHost, (uint)_settings.SQLPort);
                    client.AddForwardedPort(PortFwdL);
                    PortFwdL.Start();

                    if (!PortFwdL.IsStarted)
                    {
                        MessageBox.Show("Port forwarding failed.");
                        return;
                    }

                    MySqlConnection conn = new MySqlConnection(_settings.SQLConnectionString);
                    try
                    {
                        conn.Open();
                        MySqlCommand comm = conn.CreateCommand();
                        comm.CommandText = _settings.SQLCommandQuery;
                        comm.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Db error:" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    client.Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Process error: " + ex.Message);
                }
            }
        }
    }
}
