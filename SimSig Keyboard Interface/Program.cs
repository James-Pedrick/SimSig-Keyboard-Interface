using System;
using System.Windows.Forms;
using MainMenu = SimSig_Keyboard_Interface.User_Interface.MainDisplays.MainMenu;

namespace SimSig_Keyboard_Interface
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());
		}
	}
}
