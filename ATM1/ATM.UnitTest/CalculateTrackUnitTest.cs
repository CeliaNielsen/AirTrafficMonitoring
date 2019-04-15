using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NUnit.Framework;
using NSubstitute;

namespace ATM.UnitTest
{
    [TestFixture]
    class CalculateTrackUnitTest
    {
        private CalculateTrack _uut;
        private ITrackFormat _faketrackFormat;

        [SetUp]
        public void SetUp()
        {
            _uut = new CalculateTrack();
            List<Track> currentList = new List<Track>();
            _faketrackFormat = Substitute.For<TrackFormat>();
        }

        [Test]
        public void CalculateTrack_CalculateSpeed_returnResult()
        {
          
            DateTime time1 = new DateTime(2019, 09, 11, 09, 10, 00);
            DateTime time2 = new DateTime(2019, 09, 11, 10, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 1, 1, 100, time1, true, null, 0));
            currentList.Add(new Track("ATR423", 4, 5, 100, time2, true, null, 0));

            currentList.Add(new Track("BTR423", 4, 4, 100, time2, true, null, 0));
            _uut.CalculateSpeed(currentList);

            // Assert.That(_uut._updatedTrackList[0].Speed, Is.EqualTo(5));
            //_faketrackFormat.Received(1).Format(Arg.Is<List<Track>>(sp => sp.Count == 1 && sp[7].Speed == 0)); 


        }

        [Test]
        public void CalculateTrack_CalculateCompassCourse_returnResult()
        {
            DateTime time1 = new DateTime(2019, 09, 11, 10, 10, 00);
            DateTime time2 = new DateTime(2019, 09, 11, 9, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 0, 2, 100, time1, true, null, 0));
            _uut.CalculateCompassCourse(currentList);

            //Assert.That(_uut._updatedTrackList[0].CompassCourse, Is.EqualTo("North"));
        }

        [Test]
        public void CalculateTrack_PrintTrack_callsTrackPrint()
        {
            DateTime time1 = new DateTime(2019, 09, 11, 09, 10, 00);
            DateTime time2 = new DateTime(2019, 09, 11, 10, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 0, 0, 100, time1, true, null, 0));

            _uut.Update(currentList);
            _faketrackFormat.Received(1).UpdatePrint(new List<Track>());
        }
    }
}