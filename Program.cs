using System;
using System.Collections.Generic;

namespace human
{
    class Vehicle
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human newHuman = new Human("Scott",5,5,5,125);
            Console.WriteLine($"{newHuman.name},{newHuman.strength},{newHuman.intelligence},{newHuman.dexterity},{newHuman.health}");
        }
    }
}
