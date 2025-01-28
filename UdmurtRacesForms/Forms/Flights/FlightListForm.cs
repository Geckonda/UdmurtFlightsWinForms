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
using UdmurtFlights.Repositories;

namespace UdmurtFlights.Forms.Flights
{
    public partial class FlightListForm : Form
    {
        private readonly FlightRepository _flightRepository;
        public FlightListForm(FlightRepository flightRepository)
        {
            InitializeComponent();
            _flightRepository = flightRepository;
            LoadFlights();
        }

        private void LoadFlights()
        {
            dataGridViewFlights.DataSource = null;
            try
            {
                var flights = _flightRepository.GetAll();
                if (flights.Count <= 0)
                {
                    MessageBox.Show("Рейсов не найдено");
                    return;
                }

                dataGridViewFlights.DataSource = flights;
                RenameColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к Базе данных");
            }
        }
        private bool TryGetId(out int id)
        {
            if (dataGridViewFlights.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewFlights.SelectedRows[0];
                var cellId = selectedRow.Cells["Id"].Value;
                if (cellId != null && int.TryParse(cellId.ToString(), out id))
                    return true;
            }
            id = -1;
            return false;
        }
        private void RenameColumns()
        {
            dataGridViewFlights.Columns["Date"].HeaderText = "Дата";
            dataGridViewFlights.Columns["Time"].HeaderText = "Время";
            dataGridViewFlights.Columns["Destination"].HeaderText = "Место назначения";
            dataGridViewFlights.Columns["SeatAmount"].HeaderText = "Кол-во мест";
            dataGridViewFlights.Columns["TicketPrice"].HeaderText = "Цена";
            dataGridViewFlights.Columns["Description"].HeaderText = "Описание";
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadFlights();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TryGetId(out int clientId))
            {
                try
                {
                    var result = MessageBox.Show("Вы точно хотите удалить запись?",
                           "Осторожно!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _flightRepository.Delete(clientId);
                        MessageBox.Show("Рейс успешно удален.");
                        LoadFlights();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }

            }
            else
            {
                var result = MessageBox.Show("Выберите запись для удаления",
                       "Неверный ряд",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TryGetId(out int flightId))
            {
                try
                {
                    var flight = _flightRepository.Get(flightId);
                    if (flight == null)
                    {
                        MessageBox.Show("Произошла ошибка! Запись не найдена",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                        return;
                    }
                    FlightAddForm form = new(_flightRepository, LoadFlights, flight);
                    form.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка!",
                           "Ошибка",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                }

            }
            else
            {
                var result = MessageBox.Show("Выберите запись для редактирования",
                       "Неверный ряд",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FlightAddForm form = new(_flightRepository, LoadFlights);
            form.ShowDialog();
        }
    }
}
