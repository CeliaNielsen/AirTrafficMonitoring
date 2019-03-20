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


        public void CalculateCompassCourse()
        {
           
        }
        public double CalculateSpeed(List<Track> trackList)
        {
            double speed = 0;
            foreach (var airplane in trackList) //har vi en liste med de fly som er i airspace? 
            {
                //DateTime t1 = _dtoTrack.TimeStamp;
                //double x1 = _dtoTrack.X;
                //double y1 = _dtoTrack.Y;
                //string tag1 = _dtoTrack.Tag; 

                if (trackList.tag == tag1 && _trackList.X != x1 && _trackList.Y != y1) //når samme tag opstår i listen, så den udregne  
                {
                    //Hvis vi siger tag1 = tag, så tager den vel bare samme track? vi skal finde en måde at sikre på at det er en anden placering/track


                    //DateTime t2 = _dtoTrack.TimeStamp;
                    //double x2 = _dtoTrack.X;
                    //double y2 = _dtoTrack.Y;
        
                    //Tidsforskellen 
                    //TimeSpan td = t2-t1; 

                    //Afstanden er x og y koordinater fra første timestamp til andet timestamp (afstandsformlen)
                    //double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

                    //Hastigheden fås ved tidsforskellen delt med afstanden
                    //double speed1 = distance / Convert.ToDouble(td);
                    //speed = speed1;
                }
            }
            return speed;
        }
    }
}
