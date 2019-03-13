using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    class AirspaceFilter : IFilter
    {
        private Track _track;
        private ICalculate _calculate;
        private bool inAirspace;

        public AirspaceFilter(ICalculate calculate)
        {
            _calculate = calculate;
        }

        public void CheckAirspace()
        {
            if (_track.X <=90000 && 10000 <= _track.X && _track.Y <= 90000 && 10000 <= _track.Y)
            {
                inAirspace = true;
                Update();
            }
            else
            {
                inAirspace = false;
            }
            
        }

        public void Update() // navn?
        {
            if (inAirspace == true)
            {
                _calculate.CalculateCompassCourse(); // hvad skal t bruge af værdier 
                _calculate.CalculateSpeed();
            }

        }
    }
}
