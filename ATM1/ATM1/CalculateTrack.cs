using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    class CalculateTrack:ICalculate
    {
        //Skal have forbindelse til IConditions og IFilter 
        private IConditions _conditions;
        private IFilter _filter;
        
        //DTO'en
        private Track _dtoTrack;

        public void CalculateCompassCourse()
        {
            int compasscourse; 


        }

        public void CalculateSpeed()
        {
            int speed; 


        }

        //Metode der indeholder følgende tre værdier: Trackdata,Speed, CompassCourse
        public void CalculatedValues()
        {

        }
    }
}
