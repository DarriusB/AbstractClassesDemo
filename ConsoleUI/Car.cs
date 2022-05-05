using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }

        public bool HasTrunk { get; set; }

        public override string Year { get ; set ; }
        public override string Make { get ; set ; }
        public override string Model { get ; set ; }

        public override string DriveAbstract()
        {
            return "moving forward or backwards";
        }        
    }
}
