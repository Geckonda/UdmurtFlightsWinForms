using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdmurtFlights.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int ClientId { get; set; }
        public int StatusId { get; set; }
        public string Notes { get; set; }

        public Client TicketClient { get; set; }
        public Flight TicketFlight{ get; set; }
        public Status TicketStatus { get; set; }

    }
}
