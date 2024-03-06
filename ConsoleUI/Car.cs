using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTruck {  get; set; }
        public override void DriveAbrstract()
        {
            Console.WriteLine("The car is driving ...");
        }
    }
}
