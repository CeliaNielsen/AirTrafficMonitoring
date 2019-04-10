using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;

namespace ATM.UnitTest
{
    public class fakeCalculateTrack : ICalculate
    {
        public List<Track> List = new List<Track>();

        public void CalculateCompassCourse(List<Track> trackList)
        {
            
        }

        public void CalculateSpeed(List<Track> trackList)
        {
            trackList = List;
        }

        public void Update(List<Track> trackList)
        {
            
        }
    }
}
