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
        public List<Track> _updatedTrackList { get; private set; }
        private List<Track> _oldTrackList;
        private ITrackPrint _trackprint;
  

        public CalculateTrack()
        {
            _oldTrackList= new List<Track>();
            _updatedTrackList = new List<Track>();
            _trackprint = new TrackPrint();
        }
        public void CalculateCompassCourse(List<Track> trackList)
        { 
            foreach (var airplane in trackList)
            {
                if (airplane.X > 0 && airplane.Y > 0)
                {
                    airplane.CompassCourse = "North East";
                }
                else if (airplane.X > 0 && airplane.Y < 0)
                {
                    airplane.CompassCourse = "South East";
                }
                else if (airplane.X < 0 && airplane.Y > 0)
                {
                    airplane.CompassCourse = "North West";
                }
                else if (airplane.X < 0 && airplane.Y < 0)
                {
                    airplane.CompassCourse = "South West";
                }
                else if (airplane.X == 0 && airplane.Y > 0)
                {
                    airplane.CompassCourse = "North";
                }
                else if (airplane.X == 0 && airplane.Y < 0)
                {
                    airplane.CompassCourse = "South";
                }
                else if (airplane.X > 0 && airplane.Y == 0)
                {
                    airplane.CompassCourse = "East";
                }
                else
                {
                    airplane.CompassCourse = "West"; 
                }        
            }
            _updatedTrackList = trackList;
        }

        public void CalculateSpeed(List<Track> trackList)
        {  
            foreach (var airplane in trackList) 
            {
                foreach (var oldairplane in _oldTrackList)
                {
                    
                    if (airplane.Tag == oldairplane.Tag && airplane.X != oldairplane.X || airplane.Y != oldairplane.Y) //når samme tag opstår i listen, så den udregne  
                    {
                        //Tidsforskellen
                        double td = (airplane.TimeStamp - oldairplane.TimeStamp).Hours;

                        //Afstanden er x og y koordinater fra første timestamp til andet timestamp(afstandsformlen)
                        double distance = Math.Sqrt(Math.Pow((airplane.X - oldairplane.X), 2) + Math.Pow((airplane.Y - oldairplane.Y), 2));

                        //Hastigheden fås ved tidsforskellen delt med afstanden
                        double speed1 = distance / td; 
                        airplane.Speed = speed1;
                    }
                      
                }
                _oldTrackList.Add(airplane);

            } 
            _updatedTrackList = trackList;
            _oldTrackList = trackList;
            CalculateCompassCourse(trackList);     
        }

        public void PrintTrack()
        {
            _trackprint.PrintTrack(_updatedTrackList);
        }

    }
}
