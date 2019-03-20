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
            Console.WriteLine(updatedTrackList);    
        }
    }
}
