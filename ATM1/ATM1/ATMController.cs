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

        public List<string> TrackList { get; set; }
        public Track _track { get; private set; }

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver
            
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            TrackList = e.TransponderData;
            Console.WriteLine("The data list was received");
            sortTrackList(); // når nyt data er modtaget, skal dette sorteres 
        }

        public void sortTrackList()
        {
            _track = new Track();
            string[] array = TrackList.ToArray();
            
            _track.Tag = array[0];
            _track.X = Convert.ToDouble(array[1]);
            _track.Y = Convert.ToDouble(array[2]);
            _track.Altitude = Convert.ToDouble(array[3]);
            _track.TimeStamp = Convert.ToDateTime(array[4]);

        }


    }
}
