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

        public void RegistrerReservation(Reservation reservation)
        {
            Reservations.Add(reservation.ID, reservation);
        }
        public void PrintReservationer()
        {
            
            foreach (Reservation reservation in Reservations.Values)
            {
                int id = reservation.ID;
                //if(reservation.ID=Reservations.Values)
                //{
                Console.WriteLine(reservation);
                //}
               
            }
        }
        public void FjernReservation(Reservation reservation) 
        {
            Reservations.Remove(reservation.ID);
        }
        //OPGAVE 7 VALIDERINGSFUNKTIONER

        public int AntalReservationer(Boernegruppe bGruppe)
        {
            int antalreservationer = Reservations.Count;
            return antalreservationer; 
            //_reservation = new Dictionary<int, Reservation>();
            //bGruppe = _reservation.Boernegruppe;
            //if(bGruppe.ID=Reservations.Values)
            
        }
        public bool ReservationLedig(Reservation reservation)
        {  DateTime Booked = reservation.Tidspunkt;
            if(Booked != reservation.Tidspunkt )
            {
                return true;
            }
            else 
            {
                return false; 
            }
           
        }
        public bool ReservationsTidspunktOK(Reservation reservation)
        {
            int tidspunkt = reservation.Tidspunkt.Year;
            DayOfWeek tidspunktUgedag = reservation.Tidspunkt.DayOfWeek;
            TimeSpan tidspunkttid = reservation.Tidspunkt.TimeOfDay;
            

            if (tidspunkt != reservation.Tidspunkt.Year)
            {
                return true;
            }
            else
            {
                if (tidspunktUgedag != reservation.Tidspunkt.DayOfWeek)
                {
                    return true;
                }
                else
                {
                    if(reservation !=null)
                    {
                        List<int> _falsetidspunkter = new List<int>() { 12,14,16,18,20};
                        foreach (int tidspunkter in _falsetidspunkter)
                        {
                            if (tidspunkter.Equals(_falsetidspunkter) || tidspunkter.Equals(tidspunkttid))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else
                    {
                        if (reservation.Tidspunkt != null)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                        
                    }
                }


            }
        }
        //OPGAVE 8 VALIDERINGS FUNKTIONER FORTSAT
        public bool ReservationOK(Reservation reservation)
        {
            if(reservation.Boernegruppe == null)
            {
                return false;
            }
            else
            {
                if(AntalReservationer(reservation.Boernegruppe) < 2)
                {
                    return false;
                }
                else
                {
                    if(ReservationLedig(reservation) != true) 
                    {
                        return false;
                    }
                    else
                    {
                        if(ReservationsTidspunktOK(reservation) == true)
                        {
                            return true;
                        }
                        else 
                        { 
                            return false;
                        }
                    }
                }
            }
        }

    }
}
