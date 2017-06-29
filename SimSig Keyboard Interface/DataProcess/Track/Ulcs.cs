using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.User_Interface.MainDisplays;

namespace SimSig_Keyboard_Interface.DataProcess.Track
{
	public class Ulcs
	{
		public string HexId { get; set; }
		public string Ulc { get; set; }
		public string Ends { get; set; }
		public bool RouteSet { get; set; }
		public bool InOverlap { get; set; }
		public string OverlapName { get; set; }
		public string OverlapId { get; set; }


		public void UlcUpdate(string ulc, string data, bool isOverlap, string overlapName)
		{
			if (data == null)return;
			if (data.Equals("FFFF00"))
			{
				InOverlap = false;
				RouteSet = true;
			}
			else if (data.Equals("7FFF00"))
			{
				InOverlap = false;
				RouteSet = false;
				OverlapName = "";
				OverlapId = "";
			}
			else if (data.StartsWith("8"))
			{
				RouteSet = true;
			}
			else if(data.StartsWith("0"))
			{
				RouteSet = false;
				InOverlap = isOverlap;
				OverlapName = overlapName;
				OverlapId = data.Substring(0, 4);


			}
			else
			{

				Console.WriteLine(ulc + @" " + data + @" " + overlapName + @" " + isOverlap);
			}
			

		}
	}

}

