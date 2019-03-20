using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    interface ISeparationLog
    {
        void LogSeparation(int nr, DateTime time, string tag1, string tag, bool separation);
        //void DeactivateSeparation(string tag1, string tag2);
    }
}
