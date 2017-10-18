using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketChallenge.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        public string OpenBy { get; set; }

        [ScaffoldColumn(false)]
        public string CloseBy { get; set; }

        public bool Closed { get; set; }
    }
}
