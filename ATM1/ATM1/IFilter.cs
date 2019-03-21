using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface IFilter
    {
        List<Track> CheckAirspace(List<Track> _trackList);
    }
}
