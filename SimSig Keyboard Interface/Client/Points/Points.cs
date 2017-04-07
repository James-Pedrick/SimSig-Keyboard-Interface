using System;

namespace SimSig_Keyboard_Interface.Client.Points
{

    public class Points
	{
        public string hexId { get; set; }
        public string number { get; set; }
        public bool calledNormal = false;
        public bool calledReverse = false;
        public bool detectedNormal = false;
        public bool detectedReverse = false;
        public bool failedNormal = false;
        public bool failedReverse = false;
        public bool keyedNormal = false;
        public bool keyedReverse = false;
        public bool locked = false;
        public bool isolated = false;

        public void DataUpdate (string data)
        {
            string pointState = data.Substring(6, 3);

            int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);

            if (intValue >= 512) { locked = true; intValue = intValue - 512; }
            if (intValue >= 256) { isolated = true; intValue = intValue - 256; }
            if (intValue >= 128) { keyedReverse = true; intValue = intValue - 128; }
            if (intValue >= 064) { keyedNormal = true; intValue = intValue - 064; }
            if (intValue >= 032) { failedReverse = true; intValue = intValue - 032; }
            if (intValue >= 016) { failedNormal = true; intValue = intValue - 016; }
            if (intValue >= 008) { detectedReverse = true; intValue = intValue - 008; }
            if (intValue >= 004) { detectedNormal = true; intValue = intValue - 004; }
            if (intValue >= 002) { calledReverse = true; intValue = intValue - 002; }
            if (intValue >= 001) { calledNormal = true; }
        }
    }
}
