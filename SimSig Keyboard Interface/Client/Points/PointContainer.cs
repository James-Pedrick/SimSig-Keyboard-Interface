
using System.Linq;
using System.ComponentModel;

namespace SimSig_Keyboard_Interface.Client.Points
{
    public class PointContainer
    {
        public static BindingList<Points> PointList = new BindingList<Points>();

        public void AddPointTcp(string hId, bool[] pointStates)
        {
            if (PointList.SingleOrDefault(p => p.HexId == hId) == null)
            {
                PointList.Add(new Points
                {
                    HexId = hId,
                    CalledNormal = pointStates[0],
                    CalledReverse = pointStates[1],
                    DetectedNormal = pointStates[2],
                    DetectedReverse = pointStates[3],
                    FailedNormal = pointStates[4],
                    FailedReverse = pointStates[5],
                    KeyedNormal = pointStates[6],
                    KeyedReverse = pointStates[7],
                    Isolated = pointStates[8],
                    Locked = pointStates[9]

                    //{ cN, cR, dN, dR, fN, fR, kN, kR, iso, lo };


                });
            }
            else
            {
                PointList.Single(p => p.HexId == hId).CalledNormal = pointStates[0];
                PointList.Single(p => p.HexId == hId).CalledReverse = pointStates[1];
                PointList.Single(p => p.HexId == hId).DetectedNormal = pointStates[2];
                PointList.Single(p => p.HexId == hId).DetectedReverse = pointStates[3];
                PointList.Single(p => p.HexId == hId).FailedNormal = pointStates[4];
                PointList.Single(p => p.HexId == hId).FailedReverse = pointStates[5];
                PointList.Single(p => p.HexId == hId).KeyedNormal = pointStates[6];
                PointList.Single(p => p.HexId == hId).KeyedReverse = pointStates[7];
                PointList.Single(p => p.HexId == hId).Isolated = pointStates[8];
                PointList.Single(p => p.HexId == hId).Locked = pointStates[9];
            }
        }



        public void AddPointXml(string hId, string pointId)
        {
            if (PointList.SingleOrDefault(b => b.HexId == hId) == null)
            {
                PointList.Add(new Points { HexId = hId, Number = pointId });
            }
            else
            {
                PointList.Single(b => b.HexId == hId).Number = pointId;
            }
        }







        public void DataUpdateXml(string data)
        {
            var hexId = data.Substring(0, 4);
            var pointId = data.Substring(4, 4);

            AddPointXml(hexId, pointId);
        }


        public void DataUpdateTcp(string data)
        {
            var hexId = data.Substring(0, 4);



            bool[] pointStatesProcessed = Points.DataUpdate(data);



            AddPointTcp(hexId, pointStatesProcessed);
        }




    }
}
