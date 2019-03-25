using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class SeparationFormat:ISeparationFormat
    {
        private IPrint _print;
        public string s { get; set; }
        

        public SeparationFormat()
        {
            _print = new SeparationPrint();
        }

        public string Format(List<SeparationValues> svList)
        {
            foreach (var sv in svList)
            {
                s = Convert.ToString("SEPARATION CONDITION: \r\n" + "nr: " + sv.Nr + ", Time: " + sv.Time +
                                     ", tag A: " + sv.Tag1 + ", tag B: " + sv.Tag2);
                
            }

            return s;
        }

        public void UpdatePrint(List<SeparationValues> svList)
        {
           
            _print.Print(Format(svList));
        }


    }
}
