using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    interface ISeparationFormat
    {
        void Format(List<SeparationValues> list);
    }
}
