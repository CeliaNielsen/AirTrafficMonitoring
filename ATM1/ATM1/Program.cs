using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM1
{
    class Program
    {
        static void Main(string[] args)
        {
            var transponderReceiverFactory = TransponderReceiverFactory.CreateTransponderDataReceiver();

            ATMController atmController = new ATMController(transponderReceiverFactory);

            atmController.Start();

            Console.ReadKey();
        }
    }
}
