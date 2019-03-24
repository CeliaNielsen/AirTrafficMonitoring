using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class SeparationFormat:ISeparationFormat
    {
        private IPrint _print;
        private string s;

        public SeparationFormat()
        {
            _print = new SeparationPrint();
        }

        public void Format(List<SeparationValues> svList)
        {
            foreach (var sv in svList)
            {
                s = Convert.ToString("SEPARATION CONDITION: \r\n" + "nr: " + sv.Nr + ", Time: " + sv.Time +
                                     ", tag A: " + sv.Tag1 + ", tag B" + sv.Tag2);
                _print.Print(s);


            }
        }
    }
}
