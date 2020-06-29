using System;
using System.Data.SqlClient;

namespace ContactDBLibrary
{
    public class Contact
    {
        public int Id { get; private set; }
        public int SSN { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Contact(int id, int sSN, string firstName, string lastName)
        {
            Id = id;
            SSN = sSN;
            FirstName = firstName;
            LastName = lastName;
        }

    }

    public class Address
    {
        public int Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; set; }
        public int Zip { get; set; }


        public Address(int id, string street, string city, int zip)
        {
            Id = id;
            Street = street;
            City = city;
            Zip = zip;
        }

        


    }
}
