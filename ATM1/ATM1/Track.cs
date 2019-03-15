using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class Track //DTO
    {
        public string Tag { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Altitude { get; set; }
        public DateTime TimeStamp { get; set; }

        //public Track(string tag, double x, double y, double altitude, DateTime timeStamp)
        //{
        //    Tag = tag;
        //    X = x;
        //    Y = y;
        //    Altitude = altitude;
        //    TimeStamp = timeStamp;
        //}


    }
}
