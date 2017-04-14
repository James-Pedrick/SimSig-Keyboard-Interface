using System;
using SimSig_Keyboard_Interface.Properties;
using System.IO;
using SimSig_Keyboard_Interface.Client.Berths;
using SimSig_Keyboard_Interface.Client.Points;
using SimSig_Keyboard_Interface.Client.Signals;
using SimSig_Keyboard_Interface.Client.Track;

// ************************************************************** Load Points config file ^^^


namespace SimSig_Keyboard_Interface.Data
{
	public class SaveGameParser
	{

		private static int _pointsDecimal;
		private static int _signalDecimal;
		private static int _berthsDecimal;
		private static int _tracksDecimal;


		public static void Parse(ref BerthContainer berths, ref PointContainer points, ref SignalContainer signals, ref TrackContainer tracks) // ******************************************  brings points container ref
		{


			Console.WriteLine(@"Now Reading " + Settings.Default.wi);

			try
			{
				string itemId;

				_pointsDecimal = 0;
				_signalDecimal = 0;
				_berthsDecimal = 0;
				_tracksDecimal = 0;


				StreamReader xmlData = new StreamReader(Settings.Default.wi);

				while ((itemId = xmlData.ReadLine()) != null)
				{
					if (itemId.Contains("TBER ID=")) Berths_Parse(ref berths, itemId);					//Berths
					if (itemId.Contains("TPTS ID=")) Points_Parse(ref points, itemId);		//Points ******************** also passes container ref
					if (itemId.Contains("TSIG ID=")) Signal_Parse(ref signals, itemId);     //Signals
					if (itemId.Contains("TTCS ID="))
						Track_Parse(ref tracks, itemId);     //Signals


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


			Console.WriteLine(itemId.PadRight(11, ' ') + pointsHex + _pointsDecimal);
			

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

		private static void Track_Parse(ref TrackContainer tracks,string itemId)
		{
			string trackHex = _tracksDecimal.ToString("X").PadLeft(4, '0');

			itemId = itemId.TrimStart(' ');
			itemId = itemId.Remove(0, 10);
			itemId = itemId.TrimEnd('>');
			itemId = itemId.TrimEnd('"');

			tracks.AddTrackXml(trackHex,itemId);

			_tracksDecimal++;
		}
	}
}
