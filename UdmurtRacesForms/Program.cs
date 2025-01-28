using MySql.Data.MySqlClient;

namespace UdmurtFlights
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            const string database = "UdmurtAviaSales";
            string connectionString = $"Server=localhost;Database={database};User=root;Password=;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Открытие соединения
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainForm(connection));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}