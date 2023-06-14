using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
        public int ID { get; set; }
        public Dictionary<int, Reservation> Reservations { get; set; }
        public Reservationer(int id) 
        {
            ID = id;
            Reservations = new Dictionary<int, Reservation>();
        }

    }
}
