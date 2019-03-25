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
        private ITrackFormat _trackFormat;

        [SetUp]
        public void SetUp()
        {
            _uut = new CalculateTrack();
            List<Track> currentList = new List<Track>();
            _trackFormat = Substitute.For<TrackFormat>(); 

        }

        [Test]
        public void CalculateTrack_CalculateSpeed_returnResult()
        {
            DateTime time1 = new DateTime(2019,09,11,09,10,00);
            DateTime time2 = new DateTime(2019, 09, 11, 10, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 0, 0, 100, time1, true, null, 0));
            currentList.Add(new Track("ATR423", 3, 4, 100, time2, true, null, 0));
            currentList.Add(new Track("BTR423", 3, 4, 100, time2, true, null, 0));
            _uut.CalculateSpeed(currentList);
            //5/1 = 5 
        
            Assert.That(_uut._updatedTrackList[1].Speed, Is.EqualTo(5));
        }

        [Test]
        public void CalculateTrack_CalculateCompassCourse_returnResult()
        {
            DateTime time1 = new DateTime(2019, 09, 11, 10, 10, 00);
            DateTime time2 = new DateTime(2019, 09, 11, 9, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423",0,2,100,time1,true,null,0));
            _uut.CalculateCompassCourse(currentList);

            Assert.That(_uut._updatedTrackList[0].CompassCourse, Is.EqualTo("North"));
        }

        [Test]
        public void CalculateTrack_PrintTrack_callsTrackPrint()
        {
            DateTime time1 = new DateTime(2019, 09, 11, 09, 10, 00);
            DateTime time2 = new DateTime(2019, 09, 11, 10, 10, 00);
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 0, 0, 100, time1, true, null, 0));
            
            _uut.Update(currentList);
            _trackFormat.Received(1).UpdatePrint(new List<Track>());
        }
    }
}
