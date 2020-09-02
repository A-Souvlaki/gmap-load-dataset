using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class Office
    {


        string Ubication { get; }
        string Phone { get; }
        string Email { get; }
        string Address { get; }
        string Town { get; }
        string Schedule { get; }
        string Departament { get; }
        string Country { get; }
        string Postal_Code { get; }
        string lat { get; }
        string lon { get; }


        public string Lat
        {
            get => lat;
        }

        public string lont
        {
            get => lon;
        }

        public string Name
        {
            get => Ubication;
        }


        public Office(string ubication, string phone, string email, string address, string town, string schedule, string departament, string country, string postal_Code, string lat, string lon)
        {
            Ubication = ubication;
            Phone = phone;
            Email = email;
            Address = address;
            Town = town;
            Schedule = schedule;
            Departament = departament;
            Country = country;
            Postal_Code = postal_Code;
            this.lat = lat;
            this.lon = lon;
        }

    }
}
