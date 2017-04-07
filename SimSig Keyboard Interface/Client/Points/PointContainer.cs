using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.Client.Points
{
    public class PointContainer
    {
        public List<Points> PointList = new List<Points>();

        public void AddPoint (string hId, string pNum)
        {
            if (PointList.Exists(x => x.hexId == hId) == false)
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
