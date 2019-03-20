using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    interface ISeparationsPrint
    {
        void PrintSeparation(List<SeparationValues> svList/*int nr, DateTime time, string tag1, string tag2, bool separation*/);
    }
}
