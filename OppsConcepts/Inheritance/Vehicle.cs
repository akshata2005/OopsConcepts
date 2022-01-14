using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.Inheritance
{
    public class Vehicle
    {
        public string brand;
        public string model;
        public void start()
        {
            Console.WriteLine("vehicle starts from parent");
        }
    }
}
