using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class TrackPrint :IPrint
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }

    }
}
