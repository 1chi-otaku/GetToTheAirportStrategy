using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetToTheAirportStrategy
{
    class GetToTheAirport
    {
        AirportStategy stategy;

        public GetToTheAirport(AirportStategy stategy)
        {
            this.stategy = stategy;
        }
        public void SetStrategy(AirportStategy new_strategy)
        {
            this.stategy = new_strategy;
        }
        public void ReachAirport()
        {
            stategy.GetToTheAirport();
        }
    }
}
