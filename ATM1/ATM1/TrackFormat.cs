using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class TrackFormat:IFormat
    {
        private List<Track> updatedTrackList;
    public void Format()
    {
        foreach (var track in updatedTrackList)
        {
            Convert.ToString(track);
        }

    }
    }
}
