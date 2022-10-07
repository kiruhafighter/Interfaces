using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class RocketEngine : IEngine
    {
        public int Weight { get; }
        public int Power { get; }
        public string GetCop { get; }

        public RocketEngine()
        {
            Weight = 322;
            Power = 228;
            GetCop = "GC Tech";
        }
        public void Start()
        {
            Console.WriteLine("Engine is starting");
        }
        public void Stop()
        {
            Console.WriteLine("The flight started succesfully");
        }


    }
}
