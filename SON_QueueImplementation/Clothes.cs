using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SON_QueueImplementation
{
    // Node Class
    public class Clothes
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public Clothes Next { get; set; }

        public Clothes(string name, string brand)
        {
            Name = name;
            Brand = brand;
            Next = null;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Brand: {Brand}");
        }
    }
}

