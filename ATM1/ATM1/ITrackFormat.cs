using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface ITrackFormat
    {

        string Format(List<Track> updatedTrackList); 
        void UpdatePrint(List<Track> updatedTrackList);
    }
}
