using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface ICalculate
    {
        string CalculateCompassCourse(List<Track> trackList);

        double CalculateSpeed(List<Track> trackList);

        
    }
}
