﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public interface ICalculate
    {
        void CalculateCompassCourse(List<Track> trackList);

        void CalculateSpeed(List<Track> trackList);
        void Update(List<Track> trackList); 
    }
}
