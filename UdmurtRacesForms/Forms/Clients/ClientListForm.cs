using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdmurtFlights.Repositories;

namespace UdmurtFlights.Forms.Clients
{
    public partial class ClientListForm : Form
    {
        private readonly ClientRepository _clientRepository;
        public ClientListForm(ClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository;
            LoadClients();
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadClients()
        {
            dataGridViewClients.DataSource = null;
            try
            {
                var clients = _clientRepository.GetAll();
                if (clients.Count <= 0)
                {
                    MessageBox.Show("Клиентов не найдено");
                    return;
                }

                dataGridViewClients.DataSource = clients;
                RenameColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к Базе данных");
            }
        }
        private void RenameColumns()
        {
            dataGridViewClients.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewClients.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewClients.Columns["MiddleName"].HeaderText = "Отчество";
            dataGridViewClients.Columns["PhoneNumber"].HeaderText = "Номер телефона";
            dataGridViewClients.Columns["Address"].HeaderText = "Адресс";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadClients();
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
                        _clientRepository.Delete(clientId);
                        MessageBox.Show("Пользователь успешно удален.");
                        LoadClients();
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
        private bool TryGetId(out int id)
        {
            if (dataGridViewClients.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewClients.SelectedRows[0];
                var cellId = selectedRow.Cells["Id"].Value;
                if (cellId != null && int.TryParse(cellId.ToString(), out id))
                    return true;
            }
            id = -1;
            return false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ClientAddForm form = new(_clientRepository, LoadClients);
            form.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TryGetId(out int clientId))
            {
                try
                {
                    var client = _clientRepository.Get(clientId);
                    if (client == null)
                    {
                        MessageBox.Show("Произошла ошибка! Запись не найдена",
                          "Ошибка",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                        return;
                    }
                    ClientAddForm form = new(_clientRepository, LoadClients, client);
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
    }
}
