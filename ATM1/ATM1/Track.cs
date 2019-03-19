﻿using System;
using System.Collections.Generic;
using System.Dynamic;
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
        public bool InAirSpace { get; set; } = false;

        public Track(string tag, double x, double y, double altitude, DateTime timeStamp, bool inAirSpace)
        {
            Tag = tag;
            X = x;
            Y = y;
            Altitude = altitude;
            TimeStamp = timeStamp;
            InAirSpace = inAirSpace;
        }


    }
}
