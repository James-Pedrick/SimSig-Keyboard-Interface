using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSig_Keyboard_Interface.DataProcess
{
	class KeyboardInterface
	{
		public static void KeyboardTdInt(string data)
		{
			if (data.Contains(' ') == false) return; //Not doing anything if the user has not enterd a space after the berth
			string[] userInput = data.Split(' ');
			Data.SendPrep.Interpose(userInput[0], userInput[1]);
		}

		public static void KeyboardTdCan(string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.InterposeCancel(userInput[0]);
		}

		public static void KeyboardRouSet(string data)
		{
			if (data.Contains(' ') == false) return; //Not doing anything if the user has not enterd a space after the berth
			string[] userInput = data.Split(' ');
			Data.SendPrep.RouteSet(userInput[0], userInput[1]);
		}

		public static void KeyboardRouCan(string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.RouteCan(userInput[0]);
		}

		public static void KeyboardAutSet (string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.SigAutoSet(userInput[0]);
		}

		public static void KeyboardAutCan (string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.SigAutoCan(userInput[0]);
		}

		public static void KeyboardRepSet(string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.SigReplacementSet(userInput[0]);
		}

		public static void KeyboardRepCan (string data)
		{
			string[] userInput = data.Split(' ');
			Data.SendPrep.SigReplacementCan(userInput[0]);
		}

		public static void KeyboardPointNorm (string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyN(points[0]);
		}

		public static void KeyboardPointFree(string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyF(points[0]);
		}

		public static void KeyboardPointRev (string data)
		{
			string[] points = data.Split(' ');
			Data.SendPrep.PointsKeyR(points[0]);
		}

	}
}
