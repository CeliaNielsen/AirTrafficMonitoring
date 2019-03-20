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
        private ATMController _atmController;

        [SetUp]
        public void SetUp()
        {
            _uut = new CalculateTrack();
            _atmController = Substitute.For<ATMController>();

            //CalculateCompass()

            //CalculateSpeed()

            //to positioner med (x og y) og sætter timestamp --> udregn afstand 
            //Vælg testdata så du ved hvad output giver! 
            //Prøv også med fortegn 
        }

        [Test]
        public void CalculateTrack_calculateSpeed_returnResult()
        {
            List<Track> currentList = new List<Track>();
            currentList.Add(new Track("ATR423", 3, 4, 100, DateTime.Today, false));
                


            Assert.That(_uut.CalculateSpeed(currentList)[7], Is.EqualTo(5));
        }

    }
}
