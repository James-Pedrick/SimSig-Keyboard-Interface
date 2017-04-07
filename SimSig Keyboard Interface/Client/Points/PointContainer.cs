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
            if (PointList.SingleOrDefault(p => p.hexId == hId) == (null))
             //   if (PointList.Exists(x => x.hexId == hId) == false)
            {
                PointList.Add(new Points() {hexId = hId,number = pNum}); ;
            }
        }

        public string PrintPoints()  // ****************************** Prints list of Points
        {
            string done = "";

            foreach (Points x in PointList)
            {
                done = done + x.hexId + " " + x.number + "\n";


            }
            return done;
        }
    }
}
