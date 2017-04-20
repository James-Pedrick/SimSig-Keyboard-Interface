namespace SimSig_Keyboard_Interface.Controls.Signals
{
	public class Signals
	{
		public string HexId { get; set; }
		public string Number { get; set; }
		public string Aspect { get; set; } = "R";

		public bool IsoAppS { get; set; }
		public bool RemAppS { get; set; }
		public bool IsoAppA { get; set; }
		public bool RemAppA { get; set; }
		public bool IsoAppR { get; set; }
		public bool RemAppR { get; set; }

		public bool SignalOut { get; set; }
		public bool SignalNormal { get; set; }
		public bool SignalAuto { get; set; }

		/*********************************************************************/
		/* STILL NEEDING TO BE LOOKED AT:	Signal Update Controls as these  */
		/* don't seem right, or appear to not be correctly updating          */
		/*********************************************************************/

		public void SignalUpdateAspect(string data)
		{
			int intValue = int.Parse(data, System.Globalization.NumberStyles.HexNumber);
	
			if (intValue == 0x00) Aspect = "R";
			if (intValue == 0x01) Aspect = "C";
			if (intValue == 0x02) Aspect = "Y";
			if (intValue == 0x03) Aspect = "FY";
			if (intValue == 0x04) Aspect = "YY";
			if (intValue == 0x05) Aspect = "FYY";
			if (intValue == 0x06) Aspect = "G";
		}

		public void SignalUpdateRem(string data)
		{


			int intValue = int.Parse(data, System.Globalization.NumberStyles.HexNumber);


			if (intValue >= 0x80) { IsoAppR = true; intValue = intValue - 0x80; } else { IsoAppR = false; }
			if (intValue >= 0x40) { RemAppR = true; intValue = intValue - 0x40; } else { RemAppR = false; }


			if (intValue >= 0x08) { RemAppA = true; intValue = intValue - 0x08; } else { RemAppA = false; }
			if (intValue >= 0x04) { IsoAppA = true; intValue = intValue - 0x04; } else { IsoAppA = false; }


			if (intValue >= 0x02) { IsoAppS = true; intValue = intValue - 0x02; } else { IsoAppS = false; }
			if (intValue >= 0x01) { RemAppS = true; } else { RemAppS = false; }
		}




		public void SignalUpdateControls(string data)
		{

			switch (int.Parse(data, System.Globalization.NumberStyles.HexNumber))
			{
				case 0x00:
					SignalAuto = false;
					SignalNormal = false;
					SignalOut = true;
					break;
				case 0x02:
					SignalAuto = false;
					SignalNormal = true;
					SignalAuto = false;
					break;
				case 0x03:
					SignalAuto = false;
					SignalNormal = false;
					SignalAuto = true;
					break;
			}

			
		}

	}
}
