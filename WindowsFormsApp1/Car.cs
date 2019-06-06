using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Car
    {
        private string _name;
        public Car()
        {

        }
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
