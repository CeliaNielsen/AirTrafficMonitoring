using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM1;
using NSubstitute;
using NUnit.Framework;
using TransponderReceiver;

namespace ATM.UnitTest
{
    [TestFixture]
    public class ATMControllerUnitTest
    {
        private ATMController _uut;
        //private TestTransponderReceiver _testTransponderReceiver;
        private ITransponderReceiver _ITransponderReceiver;

        [SetUp]
        public void SetUp()
        {
            _ITransponderReceiver = Substitute.For<ITransponderReceiver>();
            _uut = new ATMController(_ITransponderReceiver);
        }

        [Test]
        public void ATMController_EventFired_ListReceiced()
        {
            List<string> currentList = new List<string>(); 
            _ITransponderReceiver.TransponderDataReady += Raise.EventWith(new RawTransponderDataEventArgs(currentList));
            Assert.That(_uut.TrackList, Is.EqualTo(currentList));
        }
    }

    internal class TestTransponderReceiver : ITransponderReceiver
    {
        public event EventHandler<RawTransponderDataEventArgs> TransponderDataReady;

        public void RaiseEvent(List<string> dataList)
        {
            TransponderDataReady?.Invoke(this, new RawTransponderDataEventArgs(dataList));
        }
    }

}
