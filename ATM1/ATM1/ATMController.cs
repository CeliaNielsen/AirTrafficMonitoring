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

        public List<string> RawTrackList { get; private set; }
        public List<Track> sortedTrackList_ { get; private set;}

        public Track _track { get; private set; }

        private IFilter airspaceFilter_;
        private ICalculate calculateTrack_;

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver
            
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            RawTrackList = e.TransponderData;
            Console.WriteLine("The data list was received");
            sortTrackList(RawTrackList);
        }

        public List<Track> sortTrackList(List<string> rawTracklist)
        {
            sortedTrackList_ = new List<Track>();
            foreach (var track in rawTracklist)
            {
                string[] array = track.Split(';');

                sortedTrackList_.Add(new Track(array[0], Convert.ToDouble(array[1]), Convert.ToDouble(array[2]), Convert.ToDouble(array[3]), DateTime.ParseExact(array[4], "yyyyMMddHHmmssfff",
                    System.Globalization.CultureInfo.InvariantCulture), Convert.ToBoolean(false)));
            }
            
            return sortedTrackList_;
        }

        public void Start()
        {
            sortTrackList(RawTrackList);
            calculateTrack_.CalculateSpeed(airspaceFilter_.CheckAirspace(sortedTrackList_));

        }



    }
}
