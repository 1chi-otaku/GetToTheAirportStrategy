using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetToTheAirportStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetToTheAirport airport = new GetToTheAirport(new BikeStrategy());

            int input = -1;

            while (input != 0) {
                Console.Clear();
                Console.WriteLine("----Get to the airport----");
                Console.WriteLine("1 - Using bike");
                Console.WriteLine("2 - Using bus");
                Console.WriteLine("3 - Using taxi");
                Console.WriteLine("0 - Exit");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 0:
                        break;

                    case 1:
                       airport.SetStrategy(new BikeStrategy());
                       airport.ReachAirport();
                       break;
                    case 2:
                        airport.SetStrategy(new BusStrategy());
                        airport.ReachAirport();
                        break;
                    case 3:
                        airport.SetStrategy(new TaxiStrategy());
                        airport.ReachAirport();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
