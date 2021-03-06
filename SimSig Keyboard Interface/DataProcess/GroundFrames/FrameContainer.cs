﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SimSig_Keyboard_Interface.DataProcess.GroundFrames
{
	public class FrameContainer
	{
		public BindingList<Frames> FrameList = new BindingList<Frames>();


		public void AddFrameXml(string hId, string fName)
		{

			if (FrameList.SingleOrDefault(f => f.HexId == hId) == null)
				FrameList.Add(new Frames{ HexId = hId, FrameName = fName });
			else
				FrameList.Single(f => f.HexId == hId).FrameName = fName;


		}





	}
}
