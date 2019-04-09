using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TransponderReceiver;

namespace ATM.UnitTest
{
    [TestFixture()]
    class AirspaceFilterUnitTest
    {
        private AirspaceFilter _uut;
        private List<Track> _trackList;

        [SetUp]
        public void SetUp()
        {
            _trackList= new List<Track>();
            _uut = new AirspaceFilter();
        }

        [TestCase(60000,40000)]
        [TestCase(50000, 40000)]
        [TestCase(90000, 90000)]
        public void CheckAirspace_TrackIsInside_returnsTrue(double x, double y)
        {
            _trackList.Add(new Track("JCT123", x, y, 500, DateTime.Now, false,"North",90));

            Assert.That(_uut.CheckAirspace(_trackList)[0].InAirSpace, Is.EqualTo(true));

        }

        [TestCase(300, 300)]
        [TestCase(-200, 400)]
        [TestCase(-200,-200)]
        [TestCase(95000, 95000)]
        [TestCase(-95000, 95000)]
        public void CheckAirspace_TrackIsOutside_returnsFalse(double x, double y)
        {
            _trackList.Add(new Track("JCT123", x, y, 500, DateTime.Now, true, "North", 90));

            foreach (var track in _uut.CheckAirspace(_trackList))
            {
                Assert.That(track.InAirSpace, Is.EqualTo(false));
            }
        }
    }

    

}
