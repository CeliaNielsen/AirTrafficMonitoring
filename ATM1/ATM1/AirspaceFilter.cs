using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class AirspaceFilter : IFilter
    {
        private List<Track> _updatedTrackList;

        public List<Track> CheckAirspace(List<Track> trackList)
        {
            _updatedTrackList = new List<Track>();
            // måske skal der laves en lokal liste som der tjekke igennem istedet, for at undgå overlap eller at listen opdateres imens den løbes igennem??
            foreach (var track in trackList)
            {
                if (track.X <= 90000 && 1000 <= track.X && track.Y <= 90000 && 1000 <= track.Y)
                {
                    track.InAirSpace = true;
                    _updatedTrackList.Add(track);

                }
                else
                    track.InAirSpace = false;
                //_updatedTrackList.Add(track);
            }

            return _updatedTrackList;
        }

    }
}
