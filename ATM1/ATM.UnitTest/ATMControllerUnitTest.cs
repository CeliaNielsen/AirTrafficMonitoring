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
        private ITransponderReceiver _ITransponderReceiver;
        private RawTransponderDataEventArgs _transponderEvent ;
        private ICalculate _calculate;
        private IFilter _filter;

        private List<string> _rawList;

        [SetUp]
        public void SetUp()
        {
            _ITransponderReceiver = Substitute.For<ITransponderReceiver>();
            _uut = new ATMController(_ITransponderReceiver);
            _calculate = Substitute.For<ICalculate>();
            _filter = Substitute.For<IFilter>();
            _rawList = new List<string>();
        }

        [Test]
        public void ATMController_EventFired_ListReceiced()
        {
            _ITransponderReceiver.TransponderDataReady += Raise.EventWith(new RawTransponderDataEventArgs(_rawList));
            Assert.That(_uut.RawTrackList, Is.EqualTo(_rawList));
        }

        [Test]
        public void ATMController_sortTrackList_ListSplited()
        {
            _rawList.Add("ATR423;39045;12932;14000;20151006213456789;false;North;0");


            Assert.That(_uut.sortTrackList(_rawList)[0].Tag, Is.EqualTo("ATR423"));
        }

        //[Test]
        //public void ATMController_startMethod_callsCalculate()
        //{
        //    List<Track> trackList = new List<Track>();
        //    _uut.Start();
        //    _filter.Received().CheckAirspace(trackList);
        //}
        
    }

}
