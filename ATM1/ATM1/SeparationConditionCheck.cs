using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    class SeparationConditionCheck : ICondition
    {
        //private DateTime _time;
        //private string _tag1;
        //private string _tag2;
        //private int _nr;
        //private bool separtion = false;
        

        ////private ISeparationLog separationLog;

        //public void CheckForSeparation(List<Track> updatedList)
        //{
            
        //        for (int i = 0; i < updatedList.Count; i++)
        //        {
        //            if (Math.Abs(updatedList[i].Y - updatedList[i++].Y) < 300 && Math.Abs(updatedList[i].X - updatedList[i++].X) < 5000) // checker for konflikt 
        //            {
        //                updatedList[i].TimeStamp = _time;
        //                updatedList[i].Tag = _tag1;
        //                updatedList[i++].Tag = _tag2;

        //                SeparationCondition(_nr+=1, _time, _tag1, _tag2, separtion = true);
        //            }
        //            else SeparationCondition(_nr += 1, _time, _tag1, _tag2, separtion = false);

        //    }
                
            
        //}

        //public void SeparationCondition(int nr, DateTime time, string tag1, string tag2, bool separation)
        //{
        //    //OBS: “Separation” condition shall remain raised as long as the two tracks are conflicting.

        //    separationLog.LogSeparation(nr, time, tag1, tag2, separation);
        //}

        //public void DeactivateSeparation(string tag3, string tag4)
        //{
        //    //
        //    //separationLog.DeactivateSeparation(tag3,tag4);
        //}

    }
}
