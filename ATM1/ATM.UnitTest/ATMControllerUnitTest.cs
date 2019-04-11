using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NSubstitute;
using NSubstitute.Exceptions;
using NUnit.Framework;
using TransponderReceiver;

namespace ATM.UnitTest
{
    [TestFixture]
    public class ATMControllerUnitTest
    {
        private ATMController _uut;
        private ITransponderReceiver _fakeTransponderReceiver;
        private RawTransponderDataEventArgs _transponderEvent;
        private ICalculate _fakeCalculate;
        private IFilter _fakeFilter;

        private List<string> _rawList;
        private List<Track> _trackList;

        [SetUp]
        public void SetUp()
        {
            _fakeTransponderReceiver = Substitute.For<ITransponderReceiver>();
            _uut = new ATMController(_fakeTransponderReceiver);
            _fakeCalculate = Substitute.For<ICalculate>();
            _fakeFilter = Substitute.For<IFilter>();
            _rawList = new List<string>();
            _trackList = new List<Track>();

            
        }

        [Test]
        public void ATMController_EventFired_ListReceiced()
        {
            _rawList.Add("ATR423;39045;12932;14000;20151006213456789;false;North;0");
            _fakeTransponderReceiver.TransponderDataReady += Raise.EventWith(new RawTransponderDataEventArgs(_rawList));

            Assert.That(_uut.sortedTrackList_.Count.Equals(1));
            //Assert.That(_fakeFilter.CheckAirspace(_trackList).Count.Equals(1));

        }

        [Test]
        public void ATMController_sortTrackList_ListSplited()
        {
            _rawList.Add("ATR423;39045;12932;14000;20151006213456789;false;North;0");

            _uut.SortTrackList(_rawList);
            Assert.That(_uut.sortedTrackList_[0].Tag, Is.EqualTo("ATR423"));

        }


    }

}
