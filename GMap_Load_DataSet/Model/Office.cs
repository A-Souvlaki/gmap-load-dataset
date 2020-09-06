using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class Office
    {
        

        public string Ubication { get; }
        public string Phone { get; }
        public string Email { get; }
        public string Address { get; }
        public string Departament { get; }
        public string Schedule { get; }
        public string Zip_Code { get; }
        public string lat { get; }
        public string lon { get; }

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


        public Office(string ubication, string phone, string email, string address, string departament, string schedule, string zip_Code, string lat, string lon)
        {
            Ubication = ubication;
            Phone = phone;
            Email = email;
            Address = address;
            Departament = departament;
            Schedule = schedule;
            Zip_Code = zip_Code;
            this.lat = lat;
            this.lon = lon;
        }

    }
}
