using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class TrackFormat : ITrackFormat
    {

        private IPrint _print;
        private string s;

        public TrackFormat()
        {
            _print = new TrackPrint();
        }

        public void Format(List<Track> updatedTrackList)
        {
            foreach (var track in updatedTrackList)
            {
                s = Convert.ToString(s = Convert.ToString("TRACK: " + "tag: " + track.Tag + ", X-coordinate: " + track.X  +
                                                          ", Y-coordinate: " + track.Y + ", altitude: " + track.Altitude + ", compass course: " + track.CompassCourse + ", in airspace: " + track.InAirSpace + ", speed: " + track.Speed + ", time: " + track.TimeStamp ));
                _print.Print(s);
            }
        }
    }
}
