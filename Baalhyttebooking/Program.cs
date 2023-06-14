namespace Baalhyttebooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1 TEST Boernegruppe.cs");
            Console.WriteLine();

            Boernegruppe b1 = new Boernegruppe("1.b","Skorpionerne","pusling",15);
            Boernegruppe b2 = new Boernegruppe("1.c", "edderkopperne","tumling",11);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();

            Console.WriteLine("Opgave 2 TEST Reservation.cs");
            Console.WriteLine();

            Reservation r1 = new Reservation(1, new DateTime().AddYears(2023).AddMonths(7).AddDays(15).AddHours(10).AddMinutes(15), b1);
            Reservation r2 = new Reservation(2, new DateTime().AddYears(2023).AddMonths(8).AddDays(16).AddHours(12).AddMinutes(30), b2);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }
    }
}