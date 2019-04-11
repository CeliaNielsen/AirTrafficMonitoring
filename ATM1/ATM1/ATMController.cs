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

        private List<string> _rawTrackList;
        private List<Track> sortedTrackList_;
        public Track _track { get; private set; }

        private IFilter airspaceFilter_;
        private ICalculate calculateTrack_;
        private ICondition separationCondition_;

        private object _lock = new object();

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver

            airspaceFilter_ = new AirspaceFilter();
            calculateTrack_ = new CalculateTrack();
            sortedTrackList_ = new List<Track>();
            separationCondition_ = new SeparationConditionCheck();
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            lock (_lock)
            {
                _rawTrackList = e.TransponderData; // lock
            }
            Start(_rawTrackList);
            
        }

        public List<Track> sortTrackList(List<string> rawTracklist)
        {
            sortedTrackList_.Clear();
            lock (_lock)
            {
                //sortedTrackList_ = new List<Track>();
                foreach (var track in rawTracklist) // lock
                {
                    string[] array = track.Split(';');

                    sortedTrackList_.Add(new Track(array[0], Convert.ToDouble(array[1]), Convert.ToDouble(array[2]),
                        Convert.ToDouble(array[3]), DateTime.ParseExact(array[4], "yyyyMMddHHmmssfff",
                            System.Globalization.CultureInfo.InvariantCulture), false, "0", 0));
                }
            }

           // Start(sortedTrackList_);

            return sortedTrackList_;
        }

        public void Start(List<string> rawTrackList)
        {
            sortTrackList(rawTrackList); // returner den splittede liste
            var list = airspaceFilter_.CheckAirspace(sortedTrackList_);
            calculateTrack_.CalculateSpeed(list);
            separationCondition_.CheckForSeparation(list);


        }



    }
}
