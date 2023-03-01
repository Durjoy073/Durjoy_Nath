using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Camera : ICanon
    {
        public string Model { get; set; }
        public string Color { get; set; }
         
        public double diapter { get; set; }

        public void TakePhoto(int width, int height)
        {
            Console.WriteLine($"Took photo of size: {width}x{height}");
        }

        public Camera(string m,string c):this (100)
        {
            Model= m;
            Color = c;
        }
       public Camera(double d) {
            diapter = d;
        }
    }

    
}
