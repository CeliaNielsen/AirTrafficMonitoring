using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NSubstitute;
using NSubstitute.Core.Arguments;
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
        private ICondition _fakeSeparationConditionCheck;

        private List<string> _rawList;

        [SetUp]
        public void SetUp()
        {
            _fakeTransponderReceiver = Substitute.For<ITransponderReceiver>();
            _uut = new ATMController(_fakeTransponderReceiver);
            _fakeCalculate = Substitute.For<ICalculate>();
            _fakeFilter = Substitute.For<IFilter>();
            _fakeSeparationConditionCheck = Substitute.For<ICondition>();
            _rawList = new List<string>();

        }

        [Test]
        public void ATMController_EventFired_ListReceiced()
        {
            // Arrange
            _uut.separationCondition_ = _fakeSeparationConditionCheck;
            _uut.calculateTrack_ = _fakeCalculate;

            _rawList.Add("ATR423;39045;12932;14000;20151006213456789;false;North;0");
            // Act
            _fakeTransponderReceiver.TransponderDataReady += Raise.EventWith(new RawTransponderDataEventArgs(_rawList));

            // Assert
            // Assert.That(_uut.sortedTrackList_.Count.Equals(1));
            _fakeCalculate.Received(1).CalculateSpeed(Arg.Is<List<Track>>(l => l.Count == 1));
            // _fakeFilter.Received(1).CheckAirspace(Arg.Is<List<Track>>(l => l.Count == 1));
            //Assert.That(_fakeFilter.CheckAirspace(_trackList).Count.Equals(1));
            _fakeSeparationConditionCheck.Received(1).CheckForSeparation(Arg.Is<List<Track>>(l => l.Count == 1 && l[0].Tag == "ATR423"));
        }

        [Test]
        public void ATMController_EventFired_CalculatorCalled()
        {
            // Arrange
            _uut.airspaceFilter_ = _fakeFilter;
            _fakeFilter.CheckAirspace(Arg.Any<List<Track>>()).Returns(new List<Track>());

            _rawList.Add("ATR423;39045;12932;14000;20151006213456789;false;North;0");
            // Act
            _fakeTransponderReceiver.TransponderDataReady += Raise.EventWith(new RawTransponderDataEventArgs(_rawList));

            // Assert
            // Assert.That(_uut.sortedTrackList_.Count.Equals(1));
            _fakeFilter.Received(1).CheckAirspace(Arg.Is<List<Track>>(l => l.Count == 1));
        }

    }

}
