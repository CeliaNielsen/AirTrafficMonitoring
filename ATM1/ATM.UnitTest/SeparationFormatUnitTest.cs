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
            //_fakeSeparationValuesesList.Add(new SeparationValues(1, "WQA123", "UQK123", DateTime.Now, true));

            string time = Convert.ToString(DateTime.Now);

            _uut.Format(_fakeSeparationValuesesList);

            //Assert.That(_uut.Format(_fakeSeparationValuesesList), Is.EqualTo("SEPARATION CONDITION: \r\n" + "nr: 0, Time: " + time + ", tag A: PLO123, tag B: UIK123"));

            //Assert.That(_uut.Format(_fakeSeparationValuesesList), Is.EqualTo("SEPARATION CONDITION: \r\n" + "nr: " + "0" + ", Time: " + time +
            //                                                                 ", tag A: " + "PLO123" + ", tag B: " + "UIK123"));

            //output.Received().OutputLine(Arg.Is<string>(str => str.Contains("00:05")));

            _iseparationsPrint.Received().Print(Arg.Is<string>(str => str.Contains("PL0123")));

        }

        [Test]
        public void Format_ValuesConvertedToString_CallPrint()
        {

            _fakeSeparationValuesesList.Add(new SeparationValues(0, "PLO123", "UIK123", DateTime.Now, true));
            _fakeSeparationValuesesList.Add(new SeparationValues(1, "WQA123", "UQK123", DateTime.Now, true));

            _uut.UpdatePrint(_fakeSeparationValuesesList);

            _iseparationsPrint.Received(2).Print(_uut.s); // listen den vil have med her bliver lavet inde i koden ??

        }



    }
}
