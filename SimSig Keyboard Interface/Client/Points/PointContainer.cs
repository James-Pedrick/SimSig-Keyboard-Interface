using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SimSig_Keyboard_Interface.Client.Points
{
    public class PointContainer
    {
        public static BindingList<Points> PointList = new BindingList<Points>();

        public void AddPoint (string hId, string pNum)
        {
            if (PointList.SingleOrDefault(p => p.HexId == hId) == (null))
             //   if (PointList.Exists(x => x.hexId == hId) == false)
            {
                PointList.Add(new Points {HexId = hId,Number = pNum});
            }
            else
            {
                PointList.Single(x => x.HexId == hId).Number = pNum;
            }
        }

        public string PrintPoints()  // ****************************** Prints list of Points
        {
            string done = "";

            foreach (Points x in PointList)
            {
                done = done + x.HexId + " " + x.Number + "\n";


            }
            return done;
        }
    }
}
