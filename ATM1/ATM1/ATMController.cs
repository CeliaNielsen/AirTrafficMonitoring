using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM1
{
    public class ATMController
    {

        public List<string> RawTrackList { get; set; }
        public List<Track> sortedTrackList_ { get; private set;}
        public Track _track { get; private set; }

        private IFilter airspaceFilter_;
        private ICalculate calculateTrack_;

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver

            airspaceFilter_ = new AirspaceFilter();
            calculateTrack_ = new CalculateTrack();
            
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            RawTrackList = e.TransponderData;
            Console.WriteLine("The data list was received");
            Start();
        }

        public List<Track> sortTrackList(List<string> rawTracklist)
        {
            sortedTrackList_ = new List<Track>();
           rawTracklist = new List<string>();
            foreach (var track in rawTracklist)
            {
                string[] array = track.Split(';');

                sortedTrackList_.Add(new Track(array[0], Convert.ToDouble(array[1]), Convert.ToDouble(array[2]), Convert.ToDouble(array[3]), DateTime.ParseExact(array[4], "yyyyMMddHHmmssfff",
                    System.Globalization.CultureInfo.InvariantCulture), Convert.ToBoolean(array[5]) == false, array[6],Convert.ToDouble(array[7])));
            }
            
            return sortedTrackList_;
        }

        public void Start()
        {
            sortTrackList(RawTrackList); // returner den splittede liste
            //airspaceFilter_.CheckAirspace(sortedTrackList_);
            //calculateTrack_.CalculateSpeed(airspaceFilter_.CheckAirspace(sortedTrackList_));


        }



    }
}
