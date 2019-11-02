using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class employee
    {
        public employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public string name { get; set; }
        public int id { get; set; }
    }
}
