﻿/*
 * Created by SharpDevelop.
 * User: Cleric
 * Date: 1.3.2018 г.
 * Time: 16:44 ч.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace vJoySerialFeeder
{
	/// <summary>
	/// Description of MultiWiiSetupForm.
	/// </summary>
	public partial class MultiWiiSetupForm : Form
	{
		public int UpdateRate { get; private set; }
		
		public MultiWiiSetupForm(int updateRate)
		{
			
			InitializeComponent();
			
			numericRate.Value = updateRate;
		}
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			UpdateRate = (int)numericRate.Value;
			DialogResult = DialogResult.OK;
			Dispose();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
