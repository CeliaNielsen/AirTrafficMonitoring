using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM1
{
    class ATMController
    {
       
        public List<string> currentSignal { get; set; }

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            currentSignal = e.TransponderData;
        }

    }
}
