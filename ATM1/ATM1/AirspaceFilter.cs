using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class AirspaceFilter : IFilter
    {
        //private Track _track;
        //private ICalculate _calculate;
        private bool inAirspace;
        public List<Track> UpdatedTrackList;

       
        public AirspaceFilter(/*ICalculate calculate/*, List<Track> trackList*/)
        {
            //_calculate = calculate;
            //_trackList = trackList;
        }

        public void CheckAirspace(List<Track> _trackList)
        {
            // måske skal der laves en lokal liste som der tjekke igennem istedet, for at undgå overlap eller at listen opdateres imens den løbes igennem??
            foreach (var track in _trackList)
            {
                if (track.X <= 90000 && 10000 <= track.X && track.Y <= 90000 && 10000 <= track.Y)
                {
                    track.InAirspace = true;
                    //Update();
                }
                else
                    track.InAirspace = false;
            }

            _trackList = UpdatedTrackList;
            
        }

        //public void Update() // navn?
        //{
        //    if (inAirspace == true)
        //    {
        //        _calculate.CalculateCompassCourse(); // hvad skal t bruge af værdier 
        //        _calculate.CalculateSpeed();
        //    }

        //}
    }
}
