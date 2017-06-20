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
			debugBerthView.DataSource = MainMenu.Berths.BerthList;
			debugCallView.DataSource = MainMenu.Calls.CallList;
			debugFlagView.DataSource = MainMenu.Flags.FlagList;
			debugFrameView.DataSource = MainMenu.Frames.FrameList;
			debugPointView.DataSource = MainMenu.Points.PointList;
			debugSignalView.DataSource = MainMenu.Signals.SignalList;
			debugSlotView.DataSource = MainMenu.Slots.SlotList;
			debugTrackView.DataSource = MainMenu.Tracks.TrackList;

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
						debugRawTcpDisplay.Items.Insert(0, element);
					}
				}));
				
			}
		}

	}
}
