using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime Tidspunkt { get; set; }
        public Boernegruppe Boernegruppe { get; set; }
        public Reservation(int id, DateTime tidspunkt, Boernegruppe boernegruppe) 
        {
            ID = id;
            Tidspunkt = tidspunkt;
            Boernegruppe = boernegruppe;
        }
        public override string ToString()
        {
            return $"Reservations ID {ID}, Tidspunkt: {Tidspunkt}, Boernegruppe: {Boernegruppe}";
        }
    }
}
