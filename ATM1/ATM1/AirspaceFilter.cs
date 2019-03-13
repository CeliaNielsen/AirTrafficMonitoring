using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    class AirspaceFilter : IFilter
    {
        // three-dimensional shape -> defined by a two-dimensional -> both sides being 8000 meter

        // x-koordinater
        // y-koordinater
        private Track _track;
        private ICalculate _calculate = new ICalculate(); 
       

        private bool inAirspace;

        public void CheckAirspace()
        {
            if (expr)
            {
                inAirspace = true;

                _calculate.CalculateTrack(_track);
            }
            
        }
    }
}
