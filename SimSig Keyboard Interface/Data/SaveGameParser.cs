using System;
using SimSig_Keyboard_Interface.Properties;
using System.IO;
using SimSig_Keyboard_Interface.DataProcess.Berths;
using SimSig_Keyboard_Interface.DataProcess.Flags;
using SimSig_Keyboard_Interface.DataProcess.GroundFrames;
using SimSig_Keyboard_Interface.DataProcess.Locations;
using SimSig_Keyboard_Interface.DataProcess.Points;
using SimSig_Keyboard_Interface.DataProcess.Signals;
using SimSig_Keyboard_Interface.DataProcess.Slots;
using SimSig_Keyboard_Interface.DataProcess.Track;

// ************************************************************** Load Points config file ^^^


namespace SimSig_Keyboard_Interface.Data
{
	public static class SaveGameParser
	{

		private static int _berthsDecimal;
		private static int _frameDecimal;
		private static int _pointsDecimal;
		private static int _signalDecimal;
		private static int _slotDecimal;
		private static int _tracksDecimal;
		private static int _flagDecimal;
		private static int _ulcDecimal;
		private static int _overlapDecimal;


		public static void Parse(
			ref BerthContainer berths,
			ref PointContainer points,
			ref SignalContainer signals,
			ref TrackContainer tracks,
			ref SlotContainer slots,
			ref FrameContainer frames,
			ref FlagContainer flags,
			ref LocationContainer locations)
		// ******************************************  brings points container ref
		{


			Console.WriteLine(@"Now Reading " + Settings.Default.wi);

			try
			{
				string itemId;

				_frameDecimal = 0;
				_flagDecimal = 0;
				_pointsDecimal = 0;
				_signalDecimal = 0;
				_slotDecimal = 0;

				_berthsDecimal = 0;
				_tracksDecimal = 0;


				StreamReader xmlData = new StreamReader(Settings.Default.wi);

				while ((itemId = xmlData.ReadLine()) != null)
				{
					if (itemId.Contains("TBER ID=")) Berths_Parse(ref berths, itemId);      //Berths
					if (itemId.Contains("TFLG ID=")) Flag_Parse(ref flags, itemId);         //Flags
					if (itemId.Contains("TFRM ID=")) Frame_Parse(ref frames, itemId);       //Ground Frames
					if (itemId.Contains("TPTS ID=")) Points_Parse(ref points, itemId);      //Points ******************** also passes container ref
					if (itemId.Contains("TSIG ID=")) Signal_Parse(ref signals, itemId);     //Signals
					if (itemId.Contains("TSlot ID=")) Slot_Parse(ref slots, itemId);        //Slots 
					if (itemId.Contains("TTCS ID=")) Track_Parse(ref tracks, itemId);       //Track
					if (itemId.Contains("TLOC ID=")) LocationParse(ref locations, itemId);  //Location
					if (itemId.Contains("TULC ID=")) UlcParse(ref tracks, itemId);          //Ulc
					if (itemId.Contains("TOVL ID=")) OverlapParse(ref tracks, itemId);

					//TULC
				}


			}
			catch (Exception e)
			{
				Console.WriteLine(@"Parsing of file has failed. Does the save XML excist, or has it been moved?");
				Console.WriteLine(e);
			}


		}



		private static void Points_Parse(ref PointContainer points, string itemId)
		{
			string pointsHex = _pointsDecimal.ToString("X").PadLeft(4, '0');    //Convert decimal counter to hex string

			/*Want to take the specific item ID only, without the	*/
			/*start and end of tag characters from the XML          */

			{
				itemId = itemId.TrimStart(' ');                   /*Want to take the spicific  */
				itemId = itemId.Remove(0, 10);                    /*item ID only, wihtout the  */
				itemId = itemId.TrimEnd('>');                     /*start and end of line chars*/
				itemId = itemId.TrimEnd('"');
			}


			Console.WriteLine(itemId.PadRight(11, ' ') + pointsHex);


			points.AddPointXml(pointsHex, itemId);

			_pointsDecimal++;
		}
		private static void Signal_Parse(ref SignalContainer signals, string itemId)
		{
			string signalHex = _signalDecimal.ToString("X").PadLeft(4, '0');

			/*start and end of tag characters from the XML          */

			{
				itemId = itemId.TrimStart(' ');                 /*Want to take the spicific  */
				itemId = itemId.Remove(0, 10);                  /*item ID only, wihtout the  */
				itemId = itemId.TrimEnd('>');                   /*start and end of line chars*/
				itemId = itemId.TrimEnd('"');
			}


			Console.WriteLine(itemId.PadRight(11, ' ') + signalHex + _signalDecimal);

			signals.AddSignalXml(signalHex, itemId);

			_signalDecimal++;
		}
		private static void Berths_Parse(ref BerthContainer berths, string itemId)
		{
			string berthsHex = _berthsDecimal.ToString("X").PadLeft(4, '0');

			/*Want to take the specific item ID only, without the	*/
			/*start and end of tag characters from the XML          */

			{
				itemId = itemId.TrimStart(' ');                   /*Want to take the spicific  */
				itemId = itemId.Remove(0, 10);                    /*item ID only, wihtout the  */
				itemId = itemId.TrimEnd('>');                     /*start and end of line chars*/
				itemId = itemId.TrimEnd('"');
			}

			Console.WriteLine(itemId.PadRight(11, ' ') + berthsHex + _berthsDecimal);


			berths.AddBerthXml(berthsHex, itemId);

			_berthsDecimal++;
		}

		private static void UlcParse(ref TrackContainer tracks, string itemId)
		{
			Console.WriteLine(itemId);

			string trackHex = _ulcDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 10);
			itemId = itemId.Substring(0, itemId.Length - 3);

			string ends = itemId.Substring(itemId.Length - 2, 2);

			tracks.AddUlcXml(trackHex, itemId, ends);

			_ulcDecimal++;
		}
		private static void Track_Parse(ref TrackContainer tracks, string itemId)
		{
			string trackHex = _tracksDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 10);
			itemId = itemId.TrimEnd('>');
			itemId = itemId.TrimEnd('"');

			tracks.AddTrackXml(trackHex, itemId);

			_tracksDecimal++;
		}
		private static void Slot_Parse(ref SlotContainer slot, string itemId)
		{
			string slotHex = _slotDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 11);
			itemId = itemId.TrimEnd('>');
			itemId = itemId.TrimEnd('"');

			slot.AddSlotXml(slotHex, itemId);
			_slotDecimal++;
		}
		private static void Frame_Parse(ref FrameContainer frame, string itemId)
		{
			string frameHex = _frameDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 11);
			itemId = itemId.TrimEnd('>');
			itemId = itemId.TrimEnd('"');

			frame.AddFrameXml(frameHex, itemId);
			_frameDecimal++;
		}
		private static void Flag_Parse(ref FlagContainer flag, string itemId)
		{
			string flagHex = _flagDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 10);

			itemId = itemId.Substring(0, itemId.Length - 3);

			flag.AddFlagXml(flagHex, itemId);
			_flagDecimal++;
		}

		private static void OverlapParse(ref TrackContainer tracks, string itemId)
		{
			Console.WriteLine(itemId);

			string trackHex = _overlapDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 10);
			itemId = itemId.Substring(0, itemId.Length - 3);


			tracks.AddOverlapXml(trackHex, itemId);

			_overlapDecimal++;
		}

		private static void LocationParse(ref LocationContainer locations, string tiploc)
		{
			tiploc = tiploc.TrimStart(' ');
			tiploc = tiploc.Remove(0, 10);
			tiploc = tiploc.Substring(0, tiploc.Length - 2);


			StreamReader tiplocReader = new StreamReader("Notes//Tiplocs.csv");

			string itemLine;

			while ((itemLine = tiplocReader.ReadLine()) != null)
			{
				if (itemLine.Contains("," + tiploc + ","))
				{
					string[] z = itemLine.Split(',');
					locations.AddTiploc(tiploc, z[2], z[3]);

					break;
				}
				//	Console.WriteLine(itemLine);
			}






		}
	}
}
