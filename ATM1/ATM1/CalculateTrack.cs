using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class CalculateTrack:ICalculate
    {
        private IFilter _filter;
        private List<Track> _trackList;

        public string CalculateCompassCourse(List<Track> trackList)
        {
            string compassCourse = null;
            foreach (var airplane in trackList)
            {
                if (airplane.X > 0 && airplane.Y > 0)
                {
                    compassCourse = "North East";
                }
                else if (airplane.X > 0 && airplane.Y < 0)
                {
                    compassCourse = "South East";
                }
                else if (airplane.X < 0 && airplane.Y > 0)
                {
                    compassCourse = "North West";
                }
                else if (airplane.X < 0 && airplane.Y < 0)
                {
                    compassCourse = "South West";
                }
                else if (airplane.X == 0 && airplane.Y > 0)
                {
                    compassCourse = "North";
                }
                else if (airplane.X == 0 && airplane.Y < 0)
                {
                    compassCourse = "South";
                }
                else if (airplane.X > 0 && airplane.Y == 0)
                {
                    compassCourse = "East";
                }
                else
                {
                    compassCourse = "West"; 
                }
            }
            return compassCourse;
        }
        public double CalculateSpeed(List<Track> trackList)
        {
            double speed = 0;
            foreach (var airplane in trackList) //har vi en liste med de fly som er i airspace? 
            {
                DateTime t1 = airplane.TimeStamp;
                double x1 = airplane.X;
                double y1 = airplane.Y;
                string tag1 = airplane.Tag; 

                if (airplane.Tag == tag1 && airplane.X != x1 && airplane.Y != y1) //når samme tag opstår i listen, så den udregne  
                {

                    DateTime t2 = airplane.TimeStamp;
                    double x2 = airplane.X;
                    double y2 = airplane.Y;

                    //Tidsforskellen
                    TimeSpan td = t2 - t1;

                    //Afstanden er x og y koordinater fra første timestamp til andet timestamp(afstandsformlen)
                    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

                    //Hastigheden fås ved tidsforskellen delt med afstanden
                    double speed1 = distance / Convert.ToDouble(td);
                    speed = speed1;
                }

                
            }
            return speed;
        }
    }
}
