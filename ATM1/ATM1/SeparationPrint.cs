using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    public class SeparationPrint : ISeparationsPrint 
    {
        public void PrintSeparation(List<SeparationValues> svList/*int nr, DateTime time, string tag1, string tag2, bool separation*/)
        {
            
                foreach (var sv in svList)
                {
                    if (sv.Conflict == true)
                    {
                        Console.WriteLine("SEPARATION CONDITION \r\n" + "nr: " + sv.Nr + "Time: " + sv.Time + "tag A: " + sv.Tag1 + "tag B" + sv.Tag2);
                    }

                    //if (svList[i].Conflict == false)
                    //{
                    //    Console.Clear();
                    //}
                }


            //}

            //while (separation == true)
            //{
            //    Console.WriteLine("SEPARATION CONDITION \r\n" + "nr: " + nr + "Time: " + time + "tag A: " + tag1 + "tag B" + tag2);
            //}
            //Console.Clear(); // ved ikke om dette virker ?? -> den skal slette udksriften hvis ikke der er konflikt 
            
            
        }
    }
}
