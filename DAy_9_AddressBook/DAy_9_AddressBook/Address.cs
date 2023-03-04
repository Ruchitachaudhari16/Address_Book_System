using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAy_9_AddressBook
{
    internal class Address
    {
        //create list of field contact
      //public List<Contact> contactList;

        //Ability to create a Contacts in AddressBook with first and last names, address, city, state, zip, phone number andemail...
        public string First_name;
        public string Last_name;
        public string A_Address;
        public string City;
        public string State;
        public int Zip;
        public int Phone_number;
        public string Email;

        public Address(string fname, string lname, string address, string city, string state, int zip, int phone_no, string email)
        {
            this.First_name = fname;
            this.Last_name = lname;
            this.A_Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone_number = phone_no;
            this.Email = email;
        }
        public  void display()

        { 
            Console.WriteLine(this.First_name + "" + this.Last_name);
            Console.WriteLine(this.A_Address + "" + this.City);
            Console.WriteLine(this.City + " " + this.State);
            Console.WriteLine(this.Zip + " " + this.Phone_number);
            Console.WriteLine(this.Email);
        }


    }
}
    