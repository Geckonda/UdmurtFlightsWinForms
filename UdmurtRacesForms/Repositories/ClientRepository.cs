using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdmurtFlights.Models;

namespace UdmurtFlights.Repositories
{
    public class ClientRepository
    {
        private readonly MySqlConnection _db;
        public ClientRepository(MySqlConnection connection)
        {
            _db = connection;
        }

        public bool Add(Client client)
        {
            string insertQuery = "INSERT INTO Clients" +
                " (last_name, first_name, middle_name, email, phone_number, home_address)" +
                "VALUES (@last_name, @first_name, @middle_name, @email, @phone_number, @home_addres)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, _db))
            {
                cmd.Parameters.AddWithValue("@last_name", client.LastName);
                cmd.Parameters.AddWithValue("@first_name", client.FirstName);
                cmd.Parameters.AddWithValue("@middle_name", client.MiddleName);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@phone_number", client.PhoneNumber);
                cmd.Parameters.AddWithValue("@home_addres", client.Address);
                
                int rowsInserted = cmd.ExecuteNonQuery();
                if(rowsInserted > 0)
                    return true;
                return false;
            }
        }
        public bool Delete(int id)
        {
            string deleteQuery = "DELETE FROM Clients WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _db))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }
        public bool Update(Client client)
        {
            string updateQuery = "UPDATE Clients " +
               "SET last_name = @last_name, first_name = @first_name," +
               " middle_name = @middle_name, email = @email, phone_number = @phone_number," +
               " home_address = @home_address" +
               " WHERE Id = @id";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _db))
            {
                cmd.Parameters.AddWithValue("@id", client.Id);
                cmd.Parameters.AddWithValue("@last_name", client.LastName);
                cmd.Parameters.AddWithValue("@first_name", client.FirstName);
                cmd.Parameters.AddWithValue("@middle_name", client.MiddleName);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.Parameters.AddWithValue("@phone_number", client.PhoneNumber);
                cmd.Parameters.AddWithValue("@home_address", client.Address);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated > 0)
                    return true;
                return false;
            }
        }
        public Client? Get(int id)
        {
            string selectQuery = "SELECT * FROM Clients WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _db))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                        return GetEntity(reader);
                    return null;
                }
            }
        }
        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();
            string selectQuery = "SELECT * FROM Clients";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _db))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        clients.Add(GetEntity(reader));
                    return clients;
                }
            }
        }
        private Client GetEntity(MySqlDataReader reader)
        {
            return new Client()
            {
                Id = reader.GetInt32("Id"),
                LastName = reader.GetString("last_name"),
                FirstName = reader.GetString("first_name"),
                MiddleName = reader.GetString("middle_name"),
                PhoneNumber = reader.GetString("phone_number"),
                Email = reader.GetString("email"),
                Address = reader.GetString("home_address"),
            };
        }
    }
}
