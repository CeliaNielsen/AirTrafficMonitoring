using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface ISeparationFormat
    {
        //List<string> Format(List<SeparationValues> list);
        void UpdatePrint(List<SeparationValues> svList);
        string Format(List<SeparationValues> svList);
    }
}
