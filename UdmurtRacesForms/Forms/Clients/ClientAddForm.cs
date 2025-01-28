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

namespace UdmurtFlights.Forms.Clients
{
    public partial class ClientAddForm : Form
    {
        private readonly ClientRepository _clientRepository;
        private readonly Action RefreshClients;
        private readonly int _clientId;
        /// <summary>
        /// Конструктор на добавление пользователя
        /// </summary>
        /// <param name="clientRepository"></param>
        /// <param name="refreshClients"></param>
        public ClientAddForm(ClientRepository clientRepository, Action refreshClients)
        {
            _clientId = 0;
            InitializeComponent();

            _clientRepository = clientRepository;
            RefreshClients = refreshClients;

            SubValidateEvent();
        }
        /// <summary>
        /// Конструктор на редактирование клиента
        /// </summary>
        /// <param name="clientRepository"></param>
        /// <param name="refreshClients"></param>
        /// <param name="client"></param>
        public ClientAddForm(ClientRepository clientRepository,
            Action refreshClients,
            Client client)
        {
            _clientId = client.Id;
            InitializeComponent();

            this.Text = "Обновление клиента";
            AddBtn.Text = "Обновить";

            _clientRepository = clientRepository;
            RefreshClients = refreshClients;
            SubValidateEvent();
            FillClientFileds(client);
        }
        private void FillClientFileds(Client client)
        {
            LastNameInput.Text = client.LastName;
            FirstNameInput.Text = client.FirstName;
            MiddleNameInput.Text = client.MiddleName;
            EmailInput.Text = client.Email;
            PhoneNumberInput.Text = client.PhoneNumber;
            AddressInput.Text = client.Address;
        }
        private void SubValidateEvent()
        {
            LastNameInput.TextChanged += ValidateInputs!;
            FirstNameInput.TextChanged += ValidateInputs!;
            MiddleNameInput.TextChanged += ValidateInputs!;
            EmailInput.TextChanged += ValidateInputs!;
            PhoneNumberInput.TextChanged += ValidateInputs!;
            AddressInput.TextChanged += ValidateInputs!;

        }
        private void ValidateInputs(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(LastNameInput.Text) &&
                !string.IsNullOrWhiteSpace(FirstNameInput.Text) &&
                !string.IsNullOrWhiteSpace(MiddleNameInput.Text) &&
                !string.IsNullOrWhiteSpace(EmailInput.Text) &&
                !string.IsNullOrWhiteSpace(PhoneNumberInput.Text) &&
                !string.IsNullOrWhiteSpace(AddressInput.Text);

            AddBtn.Enabled = allFilled;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new()
                {
                    LastName = LastNameInput.Text,
                    FirstName = FirstNameInput.Text,
                    MiddleName = MiddleNameInput.Text,
                    Email = EmailInput.Text,
                    PhoneNumber = PhoneNumberInput.Text,
                    Address = AddressInput.Text,
                };

                if(_clientId > 0)
                {
                    client.Id = _clientId;
                    _clientRepository.Update(client);
                    MessageBox.Show("Клиент успешно обновлен!");
                }
                else
                {
                    _clientRepository.Add(client);
                    MessageBox.Show("Клиент успешно добавлен!");
                }
                    RefreshClients();
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
