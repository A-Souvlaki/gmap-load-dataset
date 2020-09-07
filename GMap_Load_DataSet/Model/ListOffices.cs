using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class ListOffices
    {

        public List<Office> Offices { get; }

        public ListOffices()
        {
            Offices = new List<Office>();
        }

        public void Add_List_Map(string ubication, string phone, string email, string address, string departament, string schedule, string zip_Code, string lat, string lon)
        {
            Office c = new Office(ubication, phone, email, address, departament, schedule, zip_Code, lat, lon);
            Offices.Add(c);
        }


        public List<String> Get_Departaments()
        {
            List<String> departaments = new List<string>();

            for (int i = 0; i < Offices.Count; i++)
            {
                departaments.Add(Offices[i].Departament);
            }

            departaments.Sort();


            int index = 0;
            while (index < departaments.Count - 1)
            {
                if (departaments[index].ToString().Equals(departaments[index + 1].ToString()))
                {
                    departaments.RemoveAt(index);
                } else
                {
                    index++;
                }

            }

            return departaments;
        }

        public List<Office> Get_SubString_For_A_Search(string search) 
        {
            List<Office> o = new List<Office>();
            search = search.ToUpper();

            

            for (int i = 0; i < Offices.Count; i++)
            {   
                string re = Offices[i].Ubication.Trim();

                if (re.Contains(search.Trim()))
                {
                    o.Add(Offices[i]);
                }

                if(re.Equals(search.Trim()))
                {
                    o.Add(Offices[i]);
                }
            }
            return o;       
        }


        public List<Office> Get_Range_From_Values(int min, int max)
        {
            List<Office> o = new List<Office>();
            for (int i = 0; i < Offices.Count; i++)
            {
                string code = Offices[i].Zip_Code.Trim();
                long c = Int64.Parse(code);

                if ((c>= min && c<= max))
                {
                    o.Add(Offices[i]);
                }
            }

            return o;
        }
        
    }
}
