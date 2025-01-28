using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmurtFlights.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time {  get; set; }
        public string Destination { get; set; }
        public decimal TicketPrice { get; set; }
        public int SeatAmount { get; set; }
        public string Description { get; set; }
    }
}
