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
        private ICalculate _iICalculate;
        private Track _track;
        private List<Track> TrackList1;

        [SetUp]
        public void SetUp()
        {
            _iICalculate = Substitute.For<ICalculate>(); // fake oprettes
            //_track = Substitute.For<Track>();
            TrackList1 = new List<Track>();
            

            _uut = new AirspaceFilter(_iICalculate,TrackList1);

            //Track inside_track1 = new Track("JCT123", 60000.1, 40000, 40, DateTime.Now);
            //Track inside_track2 = new Track("JCT124", 10000, 10000, 40, DateTime.Now);
            //Track outside_track1 = new Track("JCT125", 3000.1, 90000, 40, DateTime.Now);
        }

        [Test]
        public void CheckAirspace_TrackIsInside_true()
        {
            
            TrackList1.Add(new Track("JCT123", 60000.1, 40000, 40, DateTime.Now));
            TrackList1.Add(new Track("JCT124", 10000, 10000, 40, DateTime.Now));

            Assert.That(_uut.CheckAirspace(), Is.True);
            
        }

        [Test]
        public void CheckAirspace_TrackIsInside_false()
        {
            TrackList1.Add(new Track("JCT125", 3000.1, 90000, 40, DateTime.Now));
            Assert.That(_uut.CheckAirspace(), Is.False);

        }
    }

    

}
