using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Powerpplant: Machine
    {
        public override void Start(string time)
        {
            base.Start(time);
        }

        public void poweronoff()
        {
            Console.WriteLine("The Power of the Powerplant is activated");
        }
    }
}
