using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class TrackFormat:IFormat

    {
    public void FormatTrack(List<Track> updatedTrackList)
    {
        foreach (var track in updatedTrackList)
        {
            Convert.ToString(track);
        }

    }
    }
}
