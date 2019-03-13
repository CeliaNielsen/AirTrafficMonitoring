using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM1
{
    public class ATMController
    {

        public List<string> CurrentSignal { get; set; }

        public ATMController(ITransponderReceiver transponderReceiver)
        {
            transponderReceiver.TransponderDataReady += HandleTransponderSignalEvent; // ATM forbindes til ITransponderReceiver
        }

        private void HandleTransponderSignalEvent(object sender, RawTransponderDataEventArgs e)
        {
            CurrentSignal = e.TransponderData;
           
        }

        public EventHandler Data;
        public void getTransponderSignal(RawTransponderDataEventArgs e)
        {
            Data?.Invoke(this, e);

        }

    }
}
