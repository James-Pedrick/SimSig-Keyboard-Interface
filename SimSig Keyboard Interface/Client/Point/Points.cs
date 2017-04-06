using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SimSig_Keyboard_Interface
{
	public class PointContainer
	{
		private List<Point> pointContainer = new List<Point>();

		/*
		*/
	}


	class Point
	{

		public string hexId;
		public string simNumber;
		public bool calledN;
		public bool calledR;
		public bool detectN;
		public bool detectR;
		public bool failedN;
		public bool failedR;
		public bool keyedN;
		public bool keyedR;
		public bool locked;
		public bool isolated;


		public PointContainer(string hex, string number, bool cn, bool cr, bool dn, bool dr, bool fn, bool fr, bool kn, bool kr, bool lo, bool iso)
		{
			this.hexId = hex;
			this.simNumber = number;
			this.calledN = cn;
			this.calledR = cr;
			this.detectN = dn;
			this.detectR = dr;
			this.failedN = fn;
			this.failedR = fr;
			this.keyedN = kn;
			this.keyedR = kr;
			this.locked = lo;
			this.isolated = iso;
		}

		static void pointUpdate(string data)
		{
			//	List<PointContainer> pointList;
			List<PointContainer> pointList =  new List<PointContainer>();


			string hexId;
			string number;
			bool cN = false;
			bool cR = false;
			bool dN = false;
			bool dR = false;
			bool fN = false;
			bool fR = false;
			bool kN = false;
			bool kR = false;
			bool locked = false;
			bool isolated = false;


			hexId = data.Substring(3, 3);
			string pointState = data.Substring(6, 3);

			int intValue = int.Parse(pointState, System.Globalization.NumberStyles.HexNumber); //Convert Hex String to Int Console.WriteLine(intValue);

			if (intValue >= 512) { locked = true; intValue = intValue - 512; }
			if (intValue >= 256) { isolated = true; intValue = intValue - 256; }
			if (intValue >= 128) { kR = true; intValue = intValue - 128; }
			if (intValue >= 064) { kN = true; intValue = intValue - 064; }
			if (intValue >= 032) { fR = true; intValue = intValue - 032; }
			if (intValue >= 016) { fN = true; intValue = intValue - 016; }
			if (intValue >= 008) { dR = true; intValue = intValue - 008; }
			if (intValue >= 004) { dN = true; intValue = intValue - 004; }
			if (intValue >= 002) { cR = true; intValue = intValue - 002; }
			if (intValue >= 001) { cN = true; }

			pointList.Add(new PointContainer(hexId, null, cN, cR, dN, dR, fN, fR, kN, kR, locked, isolated));
		}
	}
}

/*



	
		}
	}
}

	*/
