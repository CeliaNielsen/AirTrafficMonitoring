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
    class TrackFormatUnitTest1
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
            public void Format_FormatTrackToString_ValuesConvertedToString() // skal rettes 
            {

                _fakeTrackList.Add(new Track("ATR423", 20000, 30000, 100, DateTime.Now, true, "North", 70));

                _uut.UpdatePrint(_fakeTrackList);
                string time = Convert.ToString(DateTime.Now);

                //Assert.That(_uut.Format(_fakeSeparationValuesesList), Is.EqualTo("SEPARATION CONDITION: \r\n" + "nr: 0, Time: " + time + ", tag A: PLO123, tag B: UIK123"));

                Assert.That(_uut.Format(_fakeTrackList), Is.EqualTo("TRACK: " + "tag: " +"ATR423" + ", X-coordinate: " + "20000" +
                                                                    ", Y-coordinate: " + "30000" + ", altitude: " + "100" + ", compass course: " + "North" + ", in airspace: " + "True" + ", speed: " + "70" + ", time: " + time));


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
}
