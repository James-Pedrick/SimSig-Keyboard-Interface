using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
		}

		private void debugBerthView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
