using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdmurtFlights.Forms.Clients;
using UdmurtFlights.Forms.Flights;
using UdmurtFlights.Repositories;

namespace UdmurtFlights
{
    public partial class MainForm : Form
    {
        private readonly MySqlConnection _connection;
        public MainForm(MySqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            ClientRepository clientRepository = new(_connection);
            ClientListForm form = new ClientListForm(clientRepository);
            form.ShowDialog();
        }

        private void FlightsBtn_Click(object sender, EventArgs e)
        {
            FlightRepository flightRepository = new(_connection);
            FlightListForm form = new FlightListForm(flightRepository);
            form.ShowDialog();
        }

        private void TicketsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
