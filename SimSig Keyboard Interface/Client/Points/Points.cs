using System;

namespace SimSig_Keyboard_Interface.Client.Points
{

    public class Points
	{
        public string HexId { get; set; }
        public string Number { get; set; }
        public bool CalledNormal { get; set; }
        public bool CalledReverse { get; set; }
        public bool DetectedNormal { get; set; }
        public bool DetectedReverse { get; set; }
        public bool FailedNormal { get; set; }
        public bool FailedReverse { get; set; }
        public bool KeyedNormal { get; set; }
        public bool KeyedReverse { get; set; }
        public bool Locked { get; set; }
        public bool Isolated { get; set; }

        public void DataUpdate (string data)
        {
            string pointState = data.Substring(6, 3);

            int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);

            if (intValue >= 512) { Locked = true; intValue = intValue - 512; }
            if (intValue >= 256) { Isolated = true; intValue = intValue - 256; }
            if (intValue >= 128) { KeyedReverse = true; intValue = intValue - 128; }
            if (intValue >= 064) { KeyedNormal = true; intValue = intValue - 064; }
            if (intValue >= 032) { FailedReverse = true; intValue = intValue - 032; }
            if (intValue >= 016) { FailedNormal = true; intValue = intValue - 016; }
            if (intValue >= 008) { DetectedReverse = true; intValue = intValue - 008; }
            if (intValue >= 004) { DetectedNormal = true; intValue = intValue - 004; }
            if (intValue >= 002) { CalledReverse = true; intValue = intValue - 002; }
            if (intValue >= 001) { CalledNormal = true; }
        }
    }
}
