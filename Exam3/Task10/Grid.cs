using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
   public class Grid<D,T>
        where D : class
       where T : struct
    {
        public D Name { get; set; }
        public T Id { get; set; }
    }
}
