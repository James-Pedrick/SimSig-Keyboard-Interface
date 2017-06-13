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
	public partial class PhoneUi : UserControl
	{
		public PhoneUi()
		{
			InitializeComponent();


			callers.Items.Clear();



			callers.DisplayMember = "CallerName";
			callers.ValueMember = "CallNumber";


			callers.DataSource = MainMenu._calls.CallList;


			callMsg.Text = "";
			callResponses.Items.Clear();


		}

		private void callRespond_Click(object sender, EventArgs e)
		{
			if (MainMenu.TcpConnected == true)
			{
				var x = callResponses.SelectedIndex.ToString();

				var callId = MainMenu._calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallNumber;

				MainMenu.Connection.SendData("pN" + callId + '\\' + x + "|");

				callResponses.Items.Clear();
				callMsg.Text = "";
				Refresh();
			}

		}

		private void callers_SelectedIndexChanged(object sender, EventArgs e)
		{

			callResponses.Items.Clear();
			try
			{
				var x = MainMenu._calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallResponses;

				foreach (var i in x)
					if (i != null)
						callResponses.Items.Add(i.Substring(8).TrimEnd('\\'));


				callMsg.Text = MainMenu._calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallerMessage;

			}
			catch
			{
				callResponses.Items.Clear();
			}

		}

		private void callMsg_Click(object sender, EventArgs e)
		{

		}
	}
}
