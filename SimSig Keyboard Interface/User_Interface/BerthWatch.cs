using System;
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

		private void BerthWatchChange(Object sender, MsgEventArgs e)
		{
			string element = e.Msg;

			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate
				{
					var berthHex = element.Substring(2, 4);
				}));
			}
		}

		private void removeWatch_Click(object sender, EventArgs e)
		{
			var z = watchList.SelectedItem;


			MainMenu.Berths.BerthWatch(z.ToString(), false);
			watchList.Items.Remove(z);

		}

		private void addWatch_Click_1(object sender, EventArgs e)
		{
			if (userInput.Text.StartsWith("B") == false) return;

			string[] z = userInput.Text.Split(' ');

			var y = MainMenu.Berths.BerthHIdLookup(z[0]);
			if (y == null) return;


			MainMenu.Berths.BerthWatch(z[0], true);

			if (watchList.Items.Contains(z[0]) == false)
				watchList.Items.Add(z[0]);
		}
	}
}
