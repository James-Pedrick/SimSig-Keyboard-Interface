
namespace SimSig_Keyboard_Interface.Client.Points
{

    public class Points
    {
        public string HexId { get; set; }
        public string Number { get; set; }
        public bool CN { get; set; }
        public bool CR { get; set; }
        public bool DN { get; set; }
        public bool DR { get; set; }
        public bool FN { get; set; }
        public bool FR { get; set; }
        public bool KN { get; set; }
        public bool KR { get; set; }
        public bool Lock { get; set; }
        public bool Iso { get; set; }

        public void PointUpdate(string pointState)
        {
			

            int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);

            if (intValue >= 0x200) { Lock = true; intValue = intValue - 0x200; } else Lock = false;
            if (intValue >= 0x100) { Iso = true; intValue = intValue - 0x100; } else Iso = false;
            if (intValue >= 0x80) { KR = true; intValue = intValue - 0x80; } else KR = false;
			if (intValue >= 0x40) { KN = true; intValue = intValue - 0x40; } else KN = false;
			if (intValue >= 0x20) { FR = true; intValue = intValue - 0x20; } else FR = false;
			if (intValue >= 0x10) { FN = true; intValue = intValue - 0x10; } else FN = false;
			if (intValue >= 0x08) { DR = true; intValue = intValue - 0x08; } else DR = false;
			if (intValue >= 0x04) { DN = true; intValue = intValue - 0x04; } else DN = false;
			if (intValue >= 0x02) { CR = true; intValue = intValue - 0x02; } else CR = false;
			if (intValue >= 0x01) { CN = true; } else CN = false;

		}
    }
}
