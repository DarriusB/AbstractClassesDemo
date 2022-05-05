using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
       
        public abstract string Year { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }

        public bool hasDoors;

        public abstract string DriveAbstract();
        public virtual string DriveVirtual()
        {
            return "in lanes";
        }


    }
}
