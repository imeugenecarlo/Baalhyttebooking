using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Boernegruppe
    {
    public string ID { get; set; }
    public string Navn { get; set; }
    public string Aldersgruppe { get; set; }
    public int  AntalDeltagere { get; set; }

    public Boernegruppe(string id, string name , string aldersgruppe, int antaldeltagere) 
     {
           ID = id;
           Navn = name;
           Aldersgruppe = aldersgruppe;
           AntalDeltagere  = antaldeltagere;
     }
        public override string ToString()
        {
            return $"ID {ID}, Navn: {Navn}, Aldersgruppe,{Aldersgruppe}, Antal Deltagere: {AntalDeltagere}";
        }
    }
    
}
