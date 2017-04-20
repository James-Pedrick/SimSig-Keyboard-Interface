
namespace SimSig_Keyboard_Interface.Controls.Points
{

    public class Points
    {
        public string HexId { get; set; }
        public string Number { get; set; }
        public bool Cn { get; set; }
        public bool Cr { get; set; }
        public bool Dn { get; set; }
        public bool Dr { get; set; }
        public bool Fn { get; set; }
        public bool Fr { get; set; }
        public bool Kn { get; set; }
        public bool Kr { get; set; }
        public bool Lock { get; set; }
        public bool Iso { get; set; }
	    public bool UpdatedTcp { get; set; } = true;
	    public bool UpdatedCom { get; set; } = true;



        public void PointUpdate(string pointState)
        {
			

            int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);

            if (intValue >= 0x200) { Lock = true; intValue = intValue - 0x200; } else Lock = false;
            if (intValue >= 0x100) { Iso = true; intValue = intValue - 0x100; } else Iso = false;
            if (intValue >= 0x80) { Kr = true; intValue = intValue - 0x80; } else Kr = false;
			if (intValue >= 0x40) { Kn = true; intValue = intValue - 0x40; } else Kn = false;
			if (intValue >= 0x20) { Fr = true; intValue = intValue - 0x20; } else Fr = false;
			if (intValue >= 0x10) { Fn = true; intValue = intValue - 0x10; } else Fn = false;
			if (intValue >= 0x08) { Dr = true; intValue = intValue - 0x08; } else Dr = false;
			if (intValue >= 0x04) { Dn = true; intValue = intValue - 0x04; } else Dn = false;
			if (intValue >= 0x02) { Cr = true; intValue = intValue - 0x02; } else Cr = false;
			if (intValue >= 0x01) { Cn = true; } else Cn = false;

	        UpdatedTcp = true;
	        UpdatedCom = true;

        }
    }
}
