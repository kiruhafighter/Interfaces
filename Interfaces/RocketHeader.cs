using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class RocketHeader
    {
        public int Cosmonauts { get; private set; }
        public int MassShell { get; private set; }

        public RocketHeader()
        {
            Cosmonauts = 3;
            MassShell = 4500;
        }

        public int GetWeight()
        {
            return (Cosmonauts * 80) + MassShell;
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Message : ");
            Console.WriteLine(message);
            Console.WriteLine("Sent");
        }


    }
}
