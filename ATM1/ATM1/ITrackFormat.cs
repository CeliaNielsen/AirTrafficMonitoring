using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface ITrackFormat
    {
        void UpdatePrint(List<Track> updatedTrackList);
    }
}
