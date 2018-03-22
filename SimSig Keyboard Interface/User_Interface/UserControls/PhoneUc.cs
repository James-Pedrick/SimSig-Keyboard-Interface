﻿using System;
using System.Linq;
using System.Windows.Forms;
using MainMenu = SimSig_Keyboard_Interface.User_Interface.MainDisplays.MainMenu;

namespace SimSig_Keyboard_Interface.User_Interface.UserControls
{
	public partial class PhoneUc : UserControl
	{
		public PhoneUc()
		{
			InitializeComponent();


			callers.Items.Clear();



			callers.DisplayMember = "CallerName";
			callers.ValueMember = "CallNumber";


			callers.DataSource = MainMenu.Calls.CallList;


			callMsg.Text = "";
			callResponses.Items.Clear();


		}

		private void callRespond_Click(object sender, EventArgs e)
		{
			if (MainMenu.TcpConnected)
			{
				var x = callResponses.SelectedIndex.ToString();

				var callId = MainMenu.Calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallNumber;

				MainMenu.TcpConnection.SendData("pN" + callId + '\\' + x + "|");

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
				var x = MainMenu.Calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallResponses;

				foreach (var i in x)
					if (i != null)
						callResponses.Items.Add(i.Substring(8).TrimEnd('\\'));


				callMsg.Text = MainMenu.Calls.CallList.Single(c => c.CallNumber == callers.SelectedValue.ToString()).CallerMessage;

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