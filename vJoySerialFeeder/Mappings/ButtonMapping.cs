﻿/*
 * Created by SharpDevelop.
 * User: Cleric
 * Date: 6.2.2018 г.
 * Time: 20:01 ч.
 */
using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace vJoySerialFeeder
{
	/// <summary>
	/// Maps channel data to a button
	///
	/// There are single and dual threshold mappings.
	/// In single threshold, if channel value if below the threshold the output is 0 and 1 if above
	/// The logic can be inverted.
	/// In dual threshold, if the channel value is between the two threshold the output is 1 and 0
	/// if outside. The logic can also be inverted.
	/// </summary>
	
	[DataContract]
	public class ButtonMapping : Mapping
	{
		public VJoyBase VJoy { get; private set; }

		private VJoyCollectionBase vJoyEnumerator;

		/// <summary>
		/// Stores the mapping parameters
		/// </summary>
		[DataContract]
		public struct ButtonParameters {
			[DataMember]
			public int thresh1, thresh2, Failsafe, TriggerDuration;
			[DataMember]
			public TriggerState.Edge TriggerEdge;
			[DataMember]
			public bool notch, invert, Trigger;
			
			public bool Transform(int val) {
				bool state;
				if(!notch) {
					state = val >= thresh1;
				}
				else {
					state = val >= thresh1 && val <= thresh2;
				}
				
				return (!Trigger & invert) ^ state;
			}
		}
		
		/// <summary>
		/// vJoy button id
		/// </summary>
		[DataMember]
		public int Button;
		
		[DataMember]
		public ButtonParameters Parameters = new ButtonParameters {
			thresh1 = 511
		};
		

		private FlowLayoutPanel panel;
		private NumericUpDown channelSpinner;
		private NumericUpDown buttonSpinner;
		private Label inputLabel;
		private PictureBox buttonStateBox;
		private ComboBox joystickDropDown;

		static private Brush BRUSH_PUSHED = Brushes.LightGreen;
		static private Brush BRUSH_NOT_PUSHED = new SolidBrush(Color.FromArgb(0, 64, 0));
		
		TriggerState trigger = new TriggerState();
		

		public override Mapping Copy()
		{
			var bm = new ButtonMapping();
			bm.Parameters = Parameters;
			bm.Button = Button;
			bm.Channel = Channel;
			bm.Joystick = Joystick;
			
			return bm;
		}
		
		protected override float Transform(int val)
		{
			var p = Parameters;
			bool state = p.Transform(val);;
			
			if(p.Trigger)
				state = trigger.Trigger(state, p.TriggerEdge, p.TriggerDuration) ^ p.invert;
			
			return state ? 1f : 0f;
		}
		
		protected override float Clamp(float val)
		{
			return val > 0 ? 1 : 0;
		}
			
		
		public override void UpdateJoystick(VJoyBase vjoy)
		{
			if(Button >= 0)
				vjoy.SetButton(Button, Output > 0);
		}
		
		public override void Paint()
		{
			inputLabel.Text = Input.ToString();
			buttonStateBox.Invalidate();
		}
		
		public override System.Windows.Forms.Control GetControl()
		{
			if(panel == null)
				initializePanel();
			return panel;
		}
		
		public override void Failsafe()
		{
			if(Parameters.Failsafe > 0)
				Output = Parameters.Failsafe == 1 ? 0 : 1;
		}

		private void onJoystickChange(object sender, EventArgs e)
		{
			Joystick = joystickDropDown.SelectedIndex;
		}

		private void onChannelChange(object sender, EventArgs e)
		{
			Channel = (int)channelSpinner.Value - 1;
		}
		
		private void onButtonChange(object sender, EventArgs e)
		{
			Button = (int)buttonSpinner.Value - 1;
		}
		
		private void onButtonStatePaint(object sender, PaintEventArgs e)
		{
			bool pushed = Output > 0;
			e.Graphics.FillEllipse(pushed ? BRUSH_PUSHED : BRUSH_NOT_PUSHED,
			                       30, 0, 18, 18);
			e.Graphics.DrawEllipse(Pens.Black,
			                       30, 0, 18, 18);
		}
		
		private void onRemoveClick(object sender, EventArgs e)
		{
			Remove();
		}
		
		private void onSetupClick(object sender, EventArgs e)
		{
			using (var dialog = new ButtonSetupForm(this)) {
				if (dialog.ShowDialog() == DialogResult.OK)
					Parameters = dialog.Parameters;
			}
		}
		void ErrorMessageBox(string message, string title)
		{
			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void initializePanel()
		{
			switch (Environment.OSVersion.Platform)
			{
				case PlatformID.Win32NT:
					vJoyEnumerator = (VJoyCollectionBase)Activator.CreateInstance(Type.GetType("vJoySerialFeeder.VJoyCollectionWindows"));
					break;
				case PlatformID.Unix:
					vJoyEnumerator = (VJoyCollectionBase)Activator.CreateInstance(Type.GetType("vJoySerialFeeder.VJoyCollectionLinux"));
					break;
				default:
					ErrorMessageBox("Unsupported platform", "Fatal");
					Application.Exit();
					break;
			}

			panel = new FlowLayoutPanel();
			panel.SuspendLayout();
			panel.Size = new Size(670, 30);
			
			var label = new Label();
			label.Text = "Channel:";
			label.Size = new Size(52, 20);
			label.TextAlign = ContentAlignment.MiddleLeft;
			panel.Controls.Add(label);
			
			channelSpinner = new NumericUpDown();
			channelSpinner.Minimum = 0;
			channelSpinner.Maximum = 255;
			channelSpinner.Size = new Size(42, 20);
			channelSpinner.Value = Channel + 1;
			channelSpinner.ValueChanged += onChannelChange;
			panel.Controls.Add(channelSpinner);
			
			label = new Label();
			label.Text = "Button:";
			label.Size = new Size(42, 20);
			label.TextAlign = ContentAlignment.MiddleLeft;
			panel.Controls.Add(label);
			
			buttonSpinner = new NumericUpDown();
			buttonSpinner.Minimum = 0;
			buttonSpinner.Maximum = 128;
			buttonSpinner.Size = new Size(42, 20);
			buttonSpinner.Value = Button + 1;
			buttonSpinner.ValueChanged += onButtonChange;
			panel.Controls.Add(buttonSpinner);
			
			
			label = new Label();
			label.Text = "Input:";
			label.Size = new Size(42, 20);
			label.TextAlign = ContentAlignment.MiddleLeft;
			panel.Controls.Add(label);
				
			inputLabel = new Label();
			inputLabel.Text = "-";
			inputLabel.Size = new Size(42, 20);
			inputLabel.TextAlign = ContentAlignment.MiddleLeft;
			panel.Controls.Add(inputLabel);
			
			label = new Label();
			label.Text = "Output:";
			label.Size = new Size(42, 20);
			label.TextAlign = ContentAlignment.MiddleLeft;
			panel.Controls.Add(label);
			
			buttonStateBox = new PictureBox();
			buttonStateBox.Size = new Size(80, 20);
			buttonStateBox.Paint += onButtonStatePaint;
			panel.Controls.Add(buttonStateBox);
			
			var button = new Button();
			button.Text = "Setup";
			button.Click += onSetupClick;
			button.Size = new Size(50, 20);
			panel.Controls.Add(button);
			
			button = new Button();
			button.Text = "Remove";
			button.Click += onRemoveClick;
			button.Size = new Size(55, 20);
			panel.Controls.Add(button);

			joystickDropDown = new ComboBox();
			joystickDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
			joystickDropDown.Size = new Size(72, 20);
			joystickDropDown.Items.AddRange(vJoyEnumerator.GetJoysticks());
			joystickDropDown.SelectedIndex = Joystick;
			joystickDropDown.SelectedIndexChanged += onJoystickChange;
			panel.Controls.Add(joystickDropDown);

			panel.ResumeLayout();
		}
	}
}
