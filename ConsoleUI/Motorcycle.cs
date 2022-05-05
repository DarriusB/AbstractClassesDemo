using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }

        public override string Year { get ; set ; }
        public override string Make { get ; set ; }
        public override string Model { get ; set ; }

        public override string DriveAbstract()
        {
            return "Moving forward or backwards";
        }

        public override string DriveVirtual()
        { 
            return "lane splitting";   
        }
    }
}
