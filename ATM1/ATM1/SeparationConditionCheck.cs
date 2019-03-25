using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class SeparationConditionCheck : ICondition
    {
        private DateTime _time;
        private string _tag1;
        private string _tag2;
        private int _nr;
        private bool separtion = false;
        public List<SeparationValues> separationList;

        private int cnt = 1; // 1 da den så ikke starter med at sammenligne med sig selv
        

        private ISeparationLog separationLog;
        private ISeparationFormat separationFormat; 
        

        public SeparationConditionCheck()
        {
            separationList = new List<SeparationValues>();
            separationFormat = new SeparationFormat();
            separationLog = new SeparationLogFile();
            

        }

        public void CheckForSeparation(List<Track> updatedList)
        {
            foreach (var track in updatedList)
            {
                for (int i = cnt; i < updatedList.Count; i++) // cnt bruges da denne tælles op, og der sammenlignes derfor kun med dem fremad i listen, og ikke dem bagved
                {
                    
                        if (Math.Abs(track.Y - updatedList[i].Y) < 300 && Math.Abs(track.X - updatedList[i].X) < 5000) // checker for konflikt med den foran
                        {
                            _time = updatedList[i].TimeStamp;
                            _tag1 = updatedList[i].Tag;
                            _tag2 = track.Tag ;

                            separationList.Add(new SeparationValues(_nr += 1, _tag1, _tag2, _time, separtion = true));

                            
                        }

                    //}
                    
                }
                cnt++;

                SeparationCondition(separationList);

         }
                
            
        }

        public void SeparationCondition(List<SeparationValues> svList )
        {
            
            separationFormat.UpdatePrint(separationList);
            separationLog.LogSeparation(svList);
        }

      

    }
}
