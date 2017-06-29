using System;
using System.Windows.Forms;
using SimSig_Keyboard_Interface.Comms.TCP;
using MainMenu = SimSig_Keyboard_Interface.User_Interface.MainDisplays.MainMenu;

namespace SimSig_Keyboard_Interface.User_Interface.UserControls
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
			simTiplocs.DataSource = MainMenu.Locations.LocationList;
			ulcView.DataSource = MainMenu.Tracks.UlcList;
			overlapView.DataSource = MainMenu.Tracks.OverlapList;


			MainMenu.DebugTcpDataReceived += DebugTcpUpdate;
			MainMenu.DebugComDataReceived += DebugComUpdate;


			Timer timer = new Timer();
			timer.Interval = (10 * 1000); // 10 secs
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
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

		private void DebugComUpdate(object sender, MsgEventArgs e)
		{
			string element = e.Msg;

			if (InvokeRequired)
			{
				Invoke(new MethodInvoker(delegate
				{
					if (element != null)
						debugRawComDisplay.Items.Insert(0, element);
				}));
			}
		}




		private void timer_Tick(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
