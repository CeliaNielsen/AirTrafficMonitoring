using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NSubstitute;
using NUnit.Framework;

namespace ATM.UnitTest
{
    [TestFixture] 
    public class TrackFormatUnitTest
    {
        private TrackFormat _uut;
        private IPrint _trackprint;

        private Track _fakeTrack;
        private List<Track> _fakeTrackList;

        [SetUp]
        public void SetUp()
        {
            _uut = new TrackFormat();
            _trackprint = Substitute.For<TrackPrint>();
            _fakeTrackList = new List<Track>();
        }

        [Test]
        public void Format_FormatTrackToString_ValuesConvertedToString()
        {

            _fakeTrackList.Add(new Track("ATR423", 20000, 30000, 100, DateTime.Now, true, "North", 70));
            
            _uut.Format(_fakeTrackList);

            
        }

        [Test]
        public void Format_ValuesConvertedToString_CallPrint()
        {

            _fakeTrackList.Add(new Track("ATR423", 20000, 30000, 100, DateTime.Now, true, "North", 70));
            _fakeTrackList.Add(new Track("UTR493", 30000, 40000, 100, DateTime.Now, true, "North", 70));
            _fakeTrackList.Add(new Track("PTR923", 50000, 30000, 100, DateTime.Now, true, "North", 70));

            _uut.Format(_fakeTrackList);

            _trackprint.Received(3).Print(_uut.s); 

        }
    }
}
