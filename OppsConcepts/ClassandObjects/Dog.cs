using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.ClassandObjects
{
    public class Dog
    {
        public string breed;
        public string color;

        public static void Sleep()
        {
            Console.WriteLine("sleeping");
        }
        public static void Bark()
        {
            Console.WriteLine("barking");
        }
    }
}
