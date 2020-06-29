using System;
using System.Data.SqlClient;

namespace ContactDBLibrary
{
    public class Contact
    {
        public int Id { get; set; }
        public int SSN { get; set; }
        public string FirstName { get; set; }
    }
}
