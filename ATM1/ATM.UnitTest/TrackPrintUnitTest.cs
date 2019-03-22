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
        private TrackPrint _uut;
        private ITrackPrint _trackprint;
        private CalculateTrack _calculatetrack;
        
        [SetUp]
        public void SetUp()
        {
            _trackprint = Substitute.For<ITrackPrint>();
            _calculatetrack = Substitute.For<CalculateTrack>();
            _uut = new TrackPrint();
        }

        [Test]
        //tilstandstest for at se om den printer ud det rigtige 
        public void TrackPrint_PrintTrack_TrackPrinted()
        {

        }

        [Test]
        public void TrackPrint_calledByCalculate_ListReceived() //test for om streng modtages 
        {
            
        }
    }
}
