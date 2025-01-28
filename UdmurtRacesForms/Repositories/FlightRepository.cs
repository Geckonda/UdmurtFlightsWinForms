using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdmurtFlights.Models;

namespace UdmurtFlights.Repositories
{
    public class FlightRepository
    {
        private readonly MySqlConnection _db;
        public FlightRepository(MySqlConnection connection)
        {
            _db = connection;
        }

        public bool Add(Flight flight)
        {
            string insertQuery = "INSERT INTO Flights" +
                " (departure_date, departure_time, destination, ticket_price, seat_count, description)" +
                "VALUES (@departure_date, @departure_time, @destination, @ticket_price, @seat_count, @description)";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, _db))
            {
                cmd.Parameters.AddWithValue("@departure_date", flight.Date);
                cmd.Parameters.AddWithValue("@departure_time", flight.Time);
                cmd.Parameters.AddWithValue("@destination", flight.Destination);
                cmd.Parameters.AddWithValue("@ticket_price", flight.TicketPrice);
                cmd.Parameters.AddWithValue("@seat_count", flight.SeatAmount);
                cmd.Parameters.AddWithValue("@description", flight.Description);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }
        public bool Delete(int id)
        {
            string deleteQuery = "DELETE FROM Flights WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _db))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }
        public bool Update(Flight flight)
        {
            string updateQuery = "UPDATE Flights " +
               "SET departure_date = @departure_date, departure_time = @departure_time," +
               " destination = @destination, ticket_price = @ticket_price, seat_count = @seat_count," +
               " description = @description" +
               " WHERE Id = @id";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _db))
            {
                cmd.Parameters.AddWithValue("@id", flight.Id);
                cmd.Parameters.AddWithValue("@departure_date", flight.Date);
                cmd.Parameters.AddWithValue("@departure_time", flight.Time);
                cmd.Parameters.AddWithValue("@destination", flight.Destination);
                cmd.Parameters.AddWithValue("@ticket_price", flight.TicketPrice);
                cmd.Parameters.AddWithValue("@seat_count", flight.SeatAmount);
                cmd.Parameters.AddWithValue("@description", flight.Description);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated > 0)
                    return true;
                return false;
            }
        }
        public Flight? Get(int id)
        {
            string selectQuery = "SELECT * FROM Flights WHERE Id = @Id";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _db))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return GetEntity(reader);
                    return null;
                }
            }
        }
        public List<Flight> GetAll()
        {
            List<Flight> flights = new List<Flight>();
            string selectQuery = "SELECT * FROM Flights";
            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _db))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        flights.Add(GetEntity(reader));
                    return flights;
                }
            }
        }
        private Flight GetEntity(MySqlDataReader reader)
        {
            return new Flight()
            {
                Id = reader.GetInt32("Id"),
                Date = reader.GetDateTime("departure_date"),
                Time = TimeOnly.FromTimeSpan(reader.GetTimeSpan("departure_time")),
                Destination = reader.GetString("destination"),
                SeatAmount = reader.GetInt32("seat_count"),
                TicketPrice = reader.GetDecimal("ticket_price"),
                Description = reader.GetString("description"),
            };
        }
    }
}
