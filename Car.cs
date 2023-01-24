using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        public int Speed { get; set; }

        public Car() 
        {
            Speed= 0;
        }
        
        public int SpeedUp() 
        {
            Speed += 10;
            return Speed;
        }

        public int SpeedDown() 
        {
            Speed -= 10;
            return Speed;
        }

        public int TurnOff() 
        {
            Speed = 0;
            return Speed;
        }

        public static string GetOp() 
        {
            return Console.ReadLine(); 
        }
    }
}
