using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class AirspaceFilter : IFilter
    {
        private Track _track;
        private ICalculate _calculate;
        private bool inAirspace;
        private List<Track> _trackList;


        public AirspaceFilter(ICalculate calculate, List<Track> trackList)
        {
            _calculate = calculate;
            _trackList = trackList;
        }

        public bool CheckAirspace()
        {
            if (_trackList[0].X <= 90000 && 10000 <= _trackList[0].X && _trackList[0].Y <= 90000 && 10000 <= _trackList[0].Y)
            {
                
                return inAirspace = true;
                Update();
            }
            else
            return inAirspace = false;

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
