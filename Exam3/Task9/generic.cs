using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



 public class generic<T>
    {
    public T Reverse<T>(T s)
       where T : IList<T>
    {
        return s;
    }
    }

