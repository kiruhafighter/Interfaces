using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Rocket
    {
        public RocketHeader Header { get; set; }
        public IEngine Engine { get; set; }
        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight;
            }
        }

    }
}
