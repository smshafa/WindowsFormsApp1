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
        private int _numDoor;
        public Car()
        {

        }
        public Car(string name, int numDoor)
        {
            _name = name;
            _numDoor = numDoor;
        }

        public string Name { get => _name; set => _name = value; }
        public int NumDoor { get => _numDoor; set => _numDoor = value; }
    }
}
