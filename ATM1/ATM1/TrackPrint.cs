using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
   public class TrackPrint:ITrackPrint
    {
        public void PrintTrack(List<Track> updatedTrackList)
        {
            foreach (var track in updatedTrackList)
            {
                Console.WriteLine("Tag: "+track.Tag+" X: "+track.X+" Y: "+track.Y+" Altitude: "+track.Altitude+" Timestamp: "+track.TimeStamp+" InAirspace: "+track.InAirSpace+" Compasscourse: "+track.CompassCourse+" Speed: "+track.Speed);
            }
               
        }
    }
}
