using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   internal public class Machine
    {
        string Time = Console.ReadLine();
        public void Start(int time)
        {
            Console.WriteLine("Machine Started");
            this.Time = time;
        }
    }

    public class powerplant : Machine
    {
        public void poweronoff()
        {
            Console.WriteLine("The Power of the Powerplant is activated");
        }

      public override void start(string time)
        {
            time += time;
        }

    }
}
