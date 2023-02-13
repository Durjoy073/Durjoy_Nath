using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Camera : Icanon
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public void TakePhoto(int width, int height)
        {
            Console.WriteLine($"Took photo of size: {width}x{height}");
        }
        public void canon()
        {

        }
    }

    public interface Icanon
    {
        public void canon()
        {
            void config();
            void memory();
            Console.WriteLine("The camera name is Canon");
        }
    }
}
