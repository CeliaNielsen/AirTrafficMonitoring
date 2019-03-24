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
    class SeparationFormatUnitTest
    {
        private SeparationFormat _uut;
        private IPrint _iseparationsPrint;

        private SeparationValues _fakeSeparationValues;
        private List<SeparationValues> _fakeSeparationValuesesList;


        [SetUp]
        public void SetUp()
        {
            _uut = new SeparationFormat();

            _iseparationsPrint = Substitute.For<SeparationPrint>();
            _fakeSeparationValuesesList = new List<SeparationValues>();

            //_fakeTrackList = new List<Track>();

            //_fakeTrackList.Clear();
        }


        [Test]
        public void Format_FormatSeparationValuesToString_ValuesConvertedToString()
        {

            _fakeSeparationValuesesList.Add(new SeparationValues(0, "PLO123", "UIK123", DateTime.Now, true));
            _fakeSeparationValuesesList.Add(new SeparationValues(1, "WQA123", "UQK123", DateTime.Now, true));

            _uut.Format(_fakeSeparationValuesesList);

            //Assert.That(_uut.Format(_fakeSeparationValuesesList)[0].Tag1, Is.EqualTo("PLO123")); // som det er nu kan den ikke teste hvad der udskrives men kun hvad der er i listen
            //Assert.That(_uut.Format(_fakeSeparationValuesesList.)[0].Tag, Is.EqualTo("ATR423"));
            //hvordan tester jeg at der udksrives?
            
        }

        [Test]
        public void Format_ValuesConvertedToString_CallPrint()
        {

            _fakeSeparationValuesesList.Add(new SeparationValues(0, "PLO123", "UIK123", DateTime.Now, true));
            _fakeSeparationValuesesList.Add(new SeparationValues(1, "WQA123", "UQK123", DateTime.Now, true));

            _uut.Format(_fakeSeparationValuesesList);

            _iseparationsPrint.Received(2).Print(_uut.s); // listen den vil have med her bliver lavet inde i koden ??

        }



    }
}
