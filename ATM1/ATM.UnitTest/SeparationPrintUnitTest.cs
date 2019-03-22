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
    class SeparationPrintUnitTest
    {
        private SeparationPrint _uut;
        private ISeparationsPrint _iseparationsPrint;

        //private Track _fakeTrack;
        //private List<Track> _fakeTrackList;
        private SeparationValues _fakeSeparationValues;
        private List<SeparationValues> _fakeSeparationValuesesList;


        [SetUp]
        public void SetUp()
        {
            _uut = new SeparationPrint();

            _iseparationsPrint = Substitute.For<ISeparationsPrint>();
            _fakeSeparationValuesesList = new List<SeparationValues>();

            //_fakeTrackList = new List<Track>();

            //_fakeTrackList.Clear();
        }


        [Test]
        public void CheckForConflict_2ConflictInList_CountIs2()
        {

            _fakeSeparationValuesesList.Add(new SeparationValues(0, "PLO123", "UIK123", DateTime.Now, true));
            _fakeSeparationValuesesList.Add(new SeparationValues(1, "WQA123", "UQK123", DateTime.Now, true));

            _uut.PrintSeparation(_fakeSeparationValuesesList);

            Assert.That(_fakeSeparationValuesesList[0].Tag1, Is.EqualTo("PLO123")); // som det er nu kan den ikke teste hvad der udskrives men kun hvad der er i listen
            //hvordan tester jeg at der udksrives?
        }
    }
}
