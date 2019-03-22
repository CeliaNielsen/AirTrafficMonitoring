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
    public class TrackPrintUnitTest
    {
        private TrackFormat _uut;
        private IPrint _trackprint;
        private CalculateTrack _calculatetrack;
        
        [SetUp]
        public void SetUp()
        {
            _trackprint = Substitute.For<IPrint>();
            _calculatetrack = Substitute.For<CalculateTrack>();
            _uut = new TrackFormat();
        }

        [Test]
        public void TrackPrint_PrintTrack_TrackPrinted()
        {

        }

        [Test]
        public void TrackPrint_calledByCalculate_ListReceived() 
        {
            
        }
    }
}
