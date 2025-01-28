using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdmurtFlights.Models;
using UdmurtFlights.Repositories;

namespace UdmurtFlights.Forms.Flights
{
    public partial class FlightAddForm : Form
    {

        private readonly FlightRepository _flightRepository;
        private readonly Action RefreshFlights;
        private readonly int _flightId;
        public FlightAddForm(FlightRepository flightRepository, 
            Action refreshFlights)
        {
            _flightId = 0;
            InitializeComponent();

            _flightRepository = flightRepository;
            RefreshFlights = refreshFlights;

            SubValidateEvent();
        }
        public FlightAddForm(FlightRepository flightRepository,
           Action refreshFlights,
           Flight flight)
        {
            _flightId = flight.Id;
            InitializeComponent();

            this.Text = "Обновление рейса";
            AddBtn.Text = "Обновить";

            _flightRepository = flightRepository;
            RefreshFlights = refreshFlights;
            SubValidateEvent();
            FillClientFileds(flight);
        }
        private void FillClientFileds(Flight flight)
        {
            DateInput.Value = flight.Date;
            TimeInput.Text = flight.Time.ToString();
            DestinationInput.Text = flight.Destination;
            SeatAmountInput.Value = flight.SeatAmount;
            TicketPriceAmount.Value = flight.TicketPrice;
            DescriptionInput.Text = flight.Description;
        }
        private void SubValidateEvent()
        {
            DateInput.TextChanged += ValidateInputs!;
            TimeInput.TextChanged += ValidateInputs!;
            DestinationInput.TextChanged += ValidateInputs!;
            SeatAmountInput.TextChanged += ValidateInputs!;
            TicketPriceAmount.TextChanged += ValidateInputs!;
            DescriptionInput.TextChanged += ValidateInputs!;

        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(DateInput.Text) &&
                !string.IsNullOrWhiteSpace(DestinationInput.Text) &&
                !string.IsNullOrWhiteSpace(SeatAmountInput.Text) &&
                !string.IsNullOrWhiteSpace(TicketPriceAmount.Text) &&
                !string.IsNullOrWhiteSpace(DescriptionInput.Text);

            AddBtn.Enabled = allFilled;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var x = TimeInput.Text;
                Flight flight = new()
                {
                    Date = DateInput.Value,
                    Time = TimeOnly.Parse(TimeInput.Text),
                    Destination = DestinationInput.Text,
                    SeatAmount = (int)SeatAmountInput.Value,
                    TicketPrice = TicketPriceAmount.Value,
                    Description = DescriptionInput.Text,
                };

                if (_flightId > 0)
                {
                    flight.Id = _flightId;
                    _flightRepository.Update(flight);
                    MessageBox.Show("Рейс успешно обновлен!");
                }
                else
                {
                    _flightRepository.Add(flight);
                    MessageBox.Show("Рейс успешно добавлен!");
                }
                RefreshFlights();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
