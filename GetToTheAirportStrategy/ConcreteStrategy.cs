using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetToTheAirportStrategy
{
    interface AirportStategy
    {
        void GetToTheAirport();
    }
    class BikeStrategy : AirportStategy
    {
        public void GetToTheAirport()
        {
            Console.WriteLine("You're going to the airport using bicycle!");
            Console.WriteLine("...");
            Thread.Sleep(5000);
            Console.WriteLine("Success! You've spent 5 seconds to get to the airport. You spent 0 dollars!");
        }
    }
    class BusStrategy: AirportStategy
    {
        public void GetToTheAirport()
        {
            Console.WriteLine("You're going to the airport using bus!");
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.WriteLine("Success! You've spent 3 seconds to get to the airport. You spent 3 dollars!");
        }
    }
    class TaxiStrategy : AirportStategy
    {
        public void GetToTheAirport()
        {
            Console.WriteLine("You're going to the airport using taxe!");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Success! You've spent 1 seconds to get to the airport. You spent 10 dollars!");
        }
    }
}
