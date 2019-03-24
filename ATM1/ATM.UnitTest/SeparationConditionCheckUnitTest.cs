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
    class SeparationConditionCheckUnitTest
    {
        private SeparationConditionCheck _uut;
        private ISeparationsPrint _iseparationsPrint;
        private ICondition _iCondition;
        private Track _fakeTrack;
        private List<Track> _fakeTrackList;
        private SeparationValues _faSeparationValues;
        private List<SeparationValues> _fakeSeparationValuesesList;


        [SetUp]
        public void SetUp()
        {
            _uut = new SeparationConditionCheck();
            _iseparationsPrint = Substitute.For<SeparationPrint>();
            _iCondition = Substitute.For<ICondition>();
            _fakeTrackList = new List<Track>();
            _fakeSeparationValuesesList = new List<SeparationValues>();
            _fakeTrackList.Clear();
        }

        [Test]
        public void CheckForConflict_2ConflictInList_CountIs2()
        {
            _fakeTrackList.Add(new Track("KJL123", 40000, 50000, 12, DateTime.Now, true, "test", 260));
            _fakeTrackList.Add(new Track("KJL456", 44999, 50299, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("OPU123", 15001, 30301, 12, DateTime.Now, true, "test", 120));
            _fakeTrackList.Add(new Track("OPW256", 10001, 30000, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("UQL456", 10001, 30000, 12, DateTime.Now, true, "test", 320));

            _uut.CheckForSeparation(_fakeTrackList);
            
            Assert.That(_uut.separationList.Count, Is.EqualTo(2));

        }

        [Test]
        public void CheckForConflict_0ConflictInList_CountIs0()
        {
            _fakeTrackList.Add(new Track("KJL123", 40000, 50000, 12, DateTime.Now, true, "test", 260));
            _fakeTrackList.Add(new Track("KJL456", 30001, 58800, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("OPU123", 70701, 14800, 12, DateTime.Now, true, "test", 120));
            _fakeTrackList.Add(new Track("OPW256", 10701, 35800, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("UQL456", 10001, 30000, 12, DateTime.Now, true, "test", 320));

            _uut.CheckForSeparation(_fakeTrackList);

            Assert.That(_uut.separationList.Count, Is.EqualTo(0));

        }

        

        [Test]
        public void CheckForSeparation_finish_callSeparationCondition()
        {
            _fakeTrackList.Add(new Track("KJL123", 40000, 50000, 12, DateTime.Now, true, "test", 260));
            _fakeTrackList.Add(new Track("KJL456", 30701, 54800, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("OPU123", 70701, 14800, 12, DateTime.Now, true, "test", 120));
            _fakeTrackList.Add(new Track("OPW256", 10701, 34800, 12, DateTime.Now, true, "test", 220));
            _fakeTrackList.Add(new Track("UQL456", 10501, 30000, 12, DateTime.Now, true, "test", 320));

            _uut.CheckForSeparation(_fakeTrackList);

            //_uut.Received(1).SeparationCondition(_uut.separationList);
            _iseparationsPrint.Received(1).PrintSeparation(_uut.separationList); // listen den vil have med her bliver lavet inde i koden ??


        }


    }
}
