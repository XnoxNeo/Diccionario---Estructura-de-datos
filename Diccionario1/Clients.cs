using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario1
{
    internal class Clients
    {


        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public float totalSpent { get; set; }
        public int purchases { get; set; }

        public Clients(string name, string surname, string phone, float totalSpent, int purchases)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.totalSpent = totalSpent;
            this.purchases = purchases;

        }


    }
}
