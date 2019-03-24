using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using ATM1;
using NSubstitute;
using NUnit.Framework;

namespace ATM.UnitTest
{
    [TestFixture()]
    public class SeparationFormatUnitTest
    {
        private SeparationFormat _uut;
        private SeparationPrint _separationPrint;

        [SetUp]
        public void SetUp()
        {
            _uut = new SeparationFormat();
            _separationPrint = Substitute.For<SeparationPrint>();
        }

        [TestCase]
        public void 

    }
}
