using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Machine
    {
        string Time = Console.ReadLine();
        public virtual void Start(string time)
        {
            Console.WriteLine("Machine Started");
            this.Time = time;
        }
    }


}
