using OppsConcepts.ClassandObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.breed = "pug";
            dog1.color = "creamish";
            Console.WriteLine("dog1 details :" + dog1.breed + "," + dog1.color);

            Dog dog2 = new Dog();
            dog2.breed = "julee";
            dog2.color = "white";
            Console.WriteLine("dog2 details :" + dog2.breed + "," + dog2.color);
            Dog.Bark();
            Dog.Sleep();
            Console.WriteLine();

        }
    }
}
