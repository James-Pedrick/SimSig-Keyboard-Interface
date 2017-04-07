using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSig_Keyboard_Interface.Properties;
using System.IO;
using SimSig_Keyboard_Interface.Client.Points;



namespace SimSig_Keyboard_Interface.Data
{
	class SaveGameParser
	{

		private static int _pointsDecimal;
		private static int _signalDecimal;
		private static int _berthsDecimal;


		public static void Parse(ref PointContainer points)
		{
			

            Console.WriteLine("Now Reading " + Settings.Default.saveGameDirectory);

			try
			{
				string itemId;

				_pointsDecimal = 0;
				_signalDecimal = 0;
				_berthsDecimal = 0;



				StreamReader xmlData = new StreamReader(Settings.Default.saveGameDirectory);

				while ((itemId = xmlData.ReadLine()) != null)
				{
					if (itemId.Contains("TBER ID=")) Berths_Parse(itemId);  //Berths
					if (itemId.Contains("TPTS ID=")) Points_Parse(ref points, itemId);  //Points
					if (itemId.Contains("TSIG ID=")) Signal_Parse(itemId);  //Signals
				}


			}
			catch (Exception e)
			{
				Console.WriteLine("Parsing of file has failed. Does the save XML excist, or has it been moved?");
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
			Console.WriteLine(itemId.PadRight(11, ' ') + " - " + pointsHex + " - " + _pointsDecimal);

            points.AddPoint(pointsHex,itemId);

			_pointsDecimal++;
		}

		private static void Signal_Parse(string itemId)
		{
			string signalHex = _signalDecimal.ToString("X").PadLeft(4, '0');

			/*Want to take the specific item ID only, without the	*/
			/*start and end of tag characters from the XML          */

			{
				itemId = itemId.TrimStart(' ');                 /*Want to take the spicific  */
				itemId = itemId.Remove(0, 10);                  /*item ID only, wihtout the  */
				itemId = itemId.TrimEnd('>');                   /*start and end of line chars*/
				itemId = itemId.TrimEnd('"');
			}
			
			Console.WriteLine(itemId.PadRight(11, ' ') + " - " + signalHex + " - " + _signalDecimal);
			
			_signalDecimal++;
		}
		private static void Berths_Parse(string itemId)
		{
			string berthsHex;

			berthsHex = _berthsDecimal.ToString("X").PadLeft(4, '0');

			/*Want to take the specific item ID only, without the	*/
			/*start and end of tag characters from the XML          */

			{
				itemId = itemId.TrimStart(' ');                   /*Want to take the spicific  */
				itemId = itemId.Remove(0, 10);                    /*item ID only, wihtout the  */
				itemId = itemId.TrimEnd('>');                     /*start and end of line chars*/
				itemId = itemId.TrimEnd('"');
			}

			Console.WriteLine(itemId.PadRight(11, ' ') + " - " + berthsHex + " - " + _berthsDecimal);

			_berthsDecimal++;
		}

	}
}
