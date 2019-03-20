using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    class SeparationLogFile : ISeparationLog
    {
        public void LogSeparation(List<SeparationValues> svList)
        {
            // log to file
            foreach (var sv in svList)
            {
                FileStream output = new FileStream(@"C: \Users\Celia\Documents\UNI\4 semester\SWT (Software test )\Handin2\AirTrafficMonitoring\ATM1\ATM1\bin\Debug", FileMode.OpenOrCreate, FileAccess.Write);

                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(output, sv);

                output.Close();

            }

        }
    }
}
