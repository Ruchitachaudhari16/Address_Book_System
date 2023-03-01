using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy_9_AddressBook
{
    internal class Address
    {
        //Ability to create a Contacts in AddressBook with first and last names, address, city, state, zip, phone number andemail...
        public string First_name;
        public string Last_name;
        public string A_Address;
        public string City;
        public string State;
        public string Zip;
        public string Phone_number;
        public string Email;

        public Address( string name,string surname,string addres,string city,string state,string zip,string phone,string email)
        {
           this.First_name = name;
            this.Last_name = surname;
            this.A_Address = addres;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone_number = phone;
            this.Email = email;
        }
         public void display()
         {

             Console.WriteLine( First_name + ""  + Last_name);
             Console.WriteLine(A_Address + "" + City);
             Console.WriteLine(City + " " + State);
             Console.WriteLine(Zip + " " + Phone_number);
             Console.WriteLine(Email);
         }
    
    
    }
}
