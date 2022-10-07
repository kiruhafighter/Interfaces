using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        public static int SpecialCalculating(int power, int mass)
        {
            return (power-(mass/150)*2+90);
        }
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket();

            rocket.Header = new RocketHeader();
            rocket.Engine = new RocketEngine();

            int result = SpecialCalculating(rocket.Engine.Power, rocket.Weight);
            Console.WriteLine("Max speed : " + result);

            if (result > 200)
            {
                rocket.Engine.Start();
                System.Threading.Thread.Sleep(3000);
                rocket.Engine.Stop();
            }
            else
            {
                Console.WriteLine("Engine has not started. Some problems issued");
            }

            

            rocket.Engine = new RocketEngine2();
            

            int result2 = SpecialCalculating(rocket.Engine.Power, rocket.Weight);
            Console.WriteLine("Max Speed of the second rocket " + result2);

            if (result2 > 300)
            {
                rocket.Engine.Start();
                System.Threading.Thread.Sleep(3000);
                rocket.Engine.Stop();
            }
            else
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Oops ... It is just expirement");
            }

            
        }
    }
}
