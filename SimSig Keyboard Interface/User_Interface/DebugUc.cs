using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.TCP;

namespace SimSig_Keyboard_Interface.User_Interface
{
	public partial class DebugUc : UserControl
	{


		public DebugUc()
		{
			InitializeComponent();
			debugBerthView.DataSource = MainMenu._berths.BerthList;
			debugCallView.DataSource = MainMenu._calls.CallList;
			debugFlagView.DataSource = MainMenu._flags.FlagList;
			debugFrameView.DataSource = MainMenu._frames.FrameList;
			debugPointView.DataSource = MainMenu._points.PointList;
			debugSignalView.DataSource = MainMenu._signals.SignalList;
			debugSlotView.DataSource = MainMenu._slots.SlotList;
			debugTrackView.DataSource = MainMenu._tracks.TrackList;

			MainMenu.DebugTcpDataReceived += DebugTcpUpdate;


			//		this.Controls.Add(debugTcpRaw);
		}

		private void DebugTcpUpdate(Object sender, MsgEventArgs e)
		{
			string element = e.Msg;
			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate
				{
					if (element != null)
					{
						Console.WriteLine(element);

						debugRawTcpDisplay.Items.Insert(0, element);
					}
				}));
				
			}
		}

	}
}
