using System;
using System.Collections.Generic;

namespace ATM1
{
    internal interface ISeparationLog
    {
        void LogSeparation(List<SeparationValues> svList);
    }
}
