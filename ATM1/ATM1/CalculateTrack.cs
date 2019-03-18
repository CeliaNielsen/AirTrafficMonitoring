using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class CalculateTrack/*:ICalculate*/
    {
        //Skal have forbindelse til IConditions og IFilter 
        //private IConditions _conditions;
        private IFilter _filter;
        
        
        //DTO'en
        private Track _dtoTrack;

        public void CalculateCompassCourse()
        {
           


        }

        //public double CalculateSpeed()
        //{
        //    double speed; 
            
        //    foreach (var airplane in ) //har vi en liste med de fly som er i airspace? 
        //    {
        //        DateTime t1 = _dtoTrack.TimeStamp;
        //        double x1 = _dtoTrack.X;
        //        double y1 = _dtoTrack.Y;

        //        if (_filter.CheckAirspace() == true)
        //        {
        //            DateTime t2 = _dtoTrack.TimeStamp;
        //            double x2 = _dtoTrack.X;
        //            double y2 = _dtoTrack.Y;
        
        //            //tidsforskellen 
        //            TimeSpan td = t2-t1; 

        //            //Afstanden er x og y koordinater fra første timestamp til andet timestamp (afstandsformlen)
        //            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        //                //Hastigheden fås ved tidsforskellen delt med afstanden
        //                speed = distance / td;
        //        }
        //    }

        //    return speed;
        //}

        //Metode der indeholder følgende tre værdier: Trackdata, Speed, CompassCourse
        public void CalculatedValues()
        {

        }
    }
}
