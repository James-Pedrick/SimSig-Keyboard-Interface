using System;
using SimSig_Keyboard_Interface.Client.Berths;

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

        public static bool[] DataUpdate(string data)
        {
            string hexId = data.Substring(0, 4);
            string pointState = data.Substring(4, 3);


            var lo = false;
            var iso = false;
            var kR = false;
            var kN = false;
            var fR = false;
            var fN = false;
            var dR = false;
            var dN = false;
            var cR = false;
            var cN = false;

            int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);




            if (intValue >= 512) { lo = true; intValue = intValue - 512; }
            if (intValue >= 256) { iso = true; intValue = intValue - 256; }
            if (intValue >= 128) { kR = true; intValue = intValue - 128; }
            if (intValue >= 64) { kN = true; intValue = intValue - 64; }
            if (intValue >= 32) { fR = true; intValue = intValue - 32; }
            if (intValue >= 16) { fN = true; intValue = intValue - 16; }
            if (intValue >= 8) { dR = true; intValue = intValue - 8; }
            if (intValue >= 4) { dN = true; intValue = intValue - 4; }
            if (intValue >= 2) { cR = true; intValue = intValue - 2; }
            if (intValue >= 1) { cN = true; }

            bool[] returnVal = { cN, cR, dN, dR, fN, fR, kN, kR, iso, lo };

            return returnVal;
        }
    }
}
