using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class SeparationValues
    {
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public DateTime Time { get; set; }

        public int Nr { get; set; }
        public bool Conflict { get; set; }

        public SeparationValues(int nr, string tag1, string tag2, DateTime time, bool conflict)
        {
            Tag1 = tag1;
            Tag2 = Tag2;
            Nr = nr;
            Time = time;
            Conflict = conflict;
        }
    }
}
