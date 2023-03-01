using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface  ICanon
    {
       
        public void iso() {

            Console.WriteLine("The Iso of this Camera");
        }
        public void whitebalance()
        {
            Console.WriteLine("The White Balance mode is 'DayLight' ");
        }
       
    }
}
