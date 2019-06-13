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
        public int NumDoor;

        public Car()
        {

        }
        public Car(string name)
        {
            Name = name;
        }
        public Car(string name, int numDoor)
        {
            Name = name;
            NumDoor = numDoor;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int numDoor
        {
            get => NumDoor;
            set => NumDoor = value;
        }
    }
}
