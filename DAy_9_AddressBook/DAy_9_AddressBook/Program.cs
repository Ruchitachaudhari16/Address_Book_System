using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;
using System.Xml.Linq;

namespace DAy_9_AddressBook
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Program p1= new Program();
            Console.WriteLine("Welcome to addressBook ");
            Console.WriteLine("Enter firstname");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Lastname");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

          
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("phone number");
            int phon_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("email");
            string email = Console.ReadLine();

            Address A1 = new Address(fname, lname, address, city, state,zip, phon_no, email);
            A1.display();
            Console.ReadLine();
           

        }
    }
}