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
        //private bool inAirspace;
        private List<Track> UpdatedTrackList;

       
        public AirspaceFilter(/*ICalculate calculate/*, List<Track> trackList*/)
        {
            //_calculate = calculate;
            //_trackList = trackList;
        }

        public List<Track> CheckAirspace(List<Track> trackList)
        {
            // måske skal der laves en lokal liste som der tjekke igennem istedet, for at undgå overlap eller at listen opdateres imens den løbes igennem??
            foreach (var track in trackList)
            {
                if (track.X <= 90000 && 10000 <= track.X && track.Y <= 90000 && 10000 <= track.Y)
                {
                    track.InAirSpace = true;
                    //Update();
                }
                else
                    track.InAirSpace = false;
                
            }

            trackList = UpdatedTrackList;
            return UpdatedTrackList;
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
