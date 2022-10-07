using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class RocketEngine2 : IEngine
    {
        public int Weight { get; }
        public int Power { get; }

        public RocketEngine2()
        {
            Weight = 550;
            Power = 3000;

        }
        public void Start()
        {
            Console.WriteLine("New raw prototype of rocket engine");
        }
        public void Stop()
        {
            Console.WriteLine("Expirement finished succesfully");
        }
        public void Advertisment()
        {
            Console.WriteLine("Sony");
        }
    }
}
