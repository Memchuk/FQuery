using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System;

namespace FQuery
{
    public partial class Form1 : Form
    {
        private class ConnectionType
        {
            private bool useManual;
            private string connectionString;

            private string server;
            private string port;
            private string database;
            private string login;
            private string password; //yes, without protection, I'm not going to hash it.

            public ConnectionType(bool useManual, string connectionString, string server, string port, string database, string login, string password)
            {
                this.useManual = useManual;
                this.connectionString = connectionString;
                this.server = server;
                this.port = port;
                this.database = database;
                this.login = login;
                this.password = password;
            }

            public bool UseManual { get => useManual; set => useManual = value; }
            public string ConnectionString { get => connectionString; set => connectionString = value; }
            public string Server { get => server; set => server = value; }
            public string Port { get => port; set => port = value; }
            public string Database { get => database; set => database = value; }
            public string Login { get => login; set => login = value; }
            public string Password { get => password; set => password = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Path.GetTempPath()}\\RlF1ZXJ5.tmp"))
            {
                var base64EncodedBytes = Convert.FromBase64String(File.ReadAllText($"{Path.GetTempPath()}\\RlF1ZXJ5.tmp"));
                string Json = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                ConnectionType ConnectionData = JsonConvert.DeserializeObject<ConnectionType>(Json);

                CBManual.Checked = ConnectionData.UseManual;
                TBConnectionString.Text = ConnectionData.ConnectionString;
                TBServer.Text = ConnectionData.Server;
                TBPort.Text = ConnectionData.Port;
                TBDatabase.Text = ConnectionData.Database;
                TBLogin.Text = ConnectionData.Login;
                TBPassword.Text = ConnectionData.Password;
            }
        }

        private void saveConnectionData(object sender, EventArgs e)
        {
            ConnectionType ConnectionData = new ConnectionType(CBManual.Checked, TBConnectionString.Text, TBServer.Text, TBPort.Text, TBDatabase.Text, TBLogin.Text, TBPassword.Text);

            //It's funny that it's not a temp, but still
            //to the question why encrypt in the base64, I will answer so that they do not ACCIDENTALLY read it
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(ConnectionData, Formatting.Indented));
            File.WriteAllText($"{Path.GetTempPath()}\\RlF1ZXJ5.tmp", Convert.ToBase64String(plainTextBytes));

            MessageBox.Show("The connection fields are saved and will be filled in the next time.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckConnection_Click(object sender, EventArgs e)
        {
            if (!GetConn(out MySqlConnection conn)) return;
            try
            {
                conn.Open();

                MessageBox.Show(conn.Ping() ? "Connection successful" : "no connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void SendQuery_Click(object sender, EventArgs e)
        {
            if (!GetConn(out MySqlConnection conn)) return;
            string query = TBQuery.Text;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    string result = "";
                    for (int fc = 0; fc < reader.FieldCount; fc++)
                    {
                        result += $"{(fc != 0 ? " - " : "")}{reader.GetName(fc)}";
                    }
                    result += ":\n";
                    while (reader.Read())
                    {
                        for (int fc = 0; fc < reader.FieldCount; fc++)
                        {
                            result += $"{(fc != 0 ? " - " : "")}";
                            if (!reader.IsDBNull(fc))
                                result += $"'{reader.GetValue(fc).ToString()}'";
                            else
                                result += "null";
                        }
                        result += ";\n";
                    }
                    MessageBox.Show(result);

                }
                else
                {
                    MessageBox.Show("The query did not return any results.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool GetConn(out MySqlConnection conn)
        {
            try //due to the manual input of the connectionString, it is necessary to exclude input errors
            {
                string connectionString = "";
                if (CBManual.Checked)
                    connectionString = TBConnectionString.Text;
                else
                    connectionString = $"Server={TBServer.Text};Port={TBPort.Text};Database={TBDatabase.Text};Uid={TBLogin.Text};Pwd={TBPassword.Text};";
                conn = new MySqlConnection(connectionString);
                return true; //and also not just return MySqlConnection, but also perform a check to exit with an error in the main thread
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn = new MySqlConnection();
                return false;
            }
        }

    }
}
