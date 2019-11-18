using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesProject
{
    public class Computer
    {
        public Computer(string type, string monitor, int cores)
        {
            Type = type;
            Monitor = monitor;
            Cores = cores;
        }
        public Computer(string Type, string Monitor) : this(Type, Monitor, 4)
        {
        }
        public Computer(string Type) : this(Type, "HP")
        {
        }
        public string Type { get; set; }
        public string Monitor { get; set; }
        public int Cores { get; set; }
    }
}
