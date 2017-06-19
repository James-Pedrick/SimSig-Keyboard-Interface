using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.TCP;

namespace SimSig_Keyboard_Interface.User_Interface
{

	public partial class BerthWatch : UserControl
	{
		public BerthWatch()
		{
			InitializeComponent();

			MainMenu.BerthWatch += BerthWatchChange;
		}


		private void AddWatch_Click(object sender, EventArgs e)
		{
			if (userInput.Text.StartsWith("B") == false) return;

			string[] z = userInput.Text.Split(' ');

			var y = MainMenu._berths.BerthHIdLookup(z[0]);
			if (y == null) return;


			MainMenu._berths.BerthWatch(z[0], true);

			watchList.Items.Add(z[0]);





		}

		private void BerthWatchChange(Object sender, MsgEventArgs e)
		{
			string element = e.Msg;

			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate
				{
					var berthHex = element.Substring(2, 4);


					//
					//		if (SignalList.SingleOrDefault(s => s.HexId == hId) == null)
					//			SignalList.Add(new Signals {HexId = hId});




				}));
			}
		}

	}
}
