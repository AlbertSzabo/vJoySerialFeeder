﻿/*
 * Created by SharpDevelop.
 * User: Cleric
 * Date: 8.6.2017 г.
 * Time: 16:58 ч.
 */
namespace vJoySerialFeeder
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel panelMappings;
		private System.Windows.Forms.Button buttonAddAxis;
		private System.Windows.Forms.Button buttonAddButton;
		private System.Windows.Forms.ComboBox comboPorts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Button buttonPortsRefresh;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ComboBox comboJoysticks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboProfiles;
		private System.Windows.Forms.Button buttonLoadProfile;
		private System.Windows.Forms.Button buttonSaveProfile;
		private System.Windows.Forms.Button buttonDeleteProfile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent() {
        	this.panelMappings = new System.Windows.Forms.FlowLayoutPanel();
        	this.buttonAddAxis = new System.Windows.Forms.Button();
        	this.buttonAddButton = new System.Windows.Forms.Button();
        	this.comboPorts = new System.Windows.Forms.ComboBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.buttonConnect = new System.Windows.Forms.Button();
        	this.buttonPortsRefresh = new System.Windows.Forms.Button();
        	this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
        	this.comboJoysticks = new System.Windows.Forms.ComboBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.comboProfiles = new System.Windows.Forms.ComboBox();
        	this.buttonLoadProfile = new System.Windows.Forms.Button();
        	this.buttonSaveProfile = new System.Windows.Forms.Button();
        	this.buttonDeleteProfile = new System.Windows.Forms.Button();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.label6 = new System.Windows.Forms.Label();
        	this.comboProtocol = new System.Windows.Forms.ComboBox();
        	this.buttonMonitor = new System.Windows.Forms.Button();
        	this.buttonBitmappedButton = new System.Windows.Forms.Button();
        	this.buttonPortSetup = new System.Windows.Forms.Button();
        	this.buttonProtocolSetup = new System.Windows.Forms.Button();
        	this.buttonHelp = new System.Windows.Forms.Button();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panelMappings
        	// 
        	this.panelMappings.AutoScroll = true;
        	this.panelMappings.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        	this.panelMappings.Location = new System.Drawing.Point(12, 110);
        	this.panelMappings.Name = "panelMappings";
        	this.panelMappings.Size = new System.Drawing.Size(703, 378);
        	this.panelMappings.TabIndex = 2;
        	this.panelMappings.WrapContents = false;
        	this.panelMappings.MouseEnter += new System.EventHandler(this.FlowLayoutPanel1MouseEnter);
        	// 
        	// buttonAddAxis
        	// 
        	this.buttonAddAxis.Location = new System.Drawing.Point(12, 81);
        	this.buttonAddAxis.Name = "buttonAddAxis";
        	this.buttonAddAxis.Size = new System.Drawing.Size(66, 23);
        	this.buttonAddAxis.TabIndex = 10;
        	this.buttonAddAxis.Text = "Add Axis";
        	this.buttonAddAxis.UseVisualStyleBackColor = true;
        	this.buttonAddAxis.Click += new System.EventHandler(this.ButtonAddAxisClick);
        	// 
        	// buttonAddButton
        	// 
        	this.buttonAddButton.Location = new System.Drawing.Point(84, 81);
        	this.buttonAddButton.Name = "buttonAddButton";
        	this.buttonAddButton.Size = new System.Drawing.Size(75, 23);
        	this.buttonAddButton.TabIndex = 11;
        	this.buttonAddButton.Text = "Add Button";
        	this.buttonAddButton.UseVisualStyleBackColor = true;
        	this.buttonAddButton.Click += new System.EventHandler(this.ButtonAddButtonClick);
        	// 
        	// comboPorts
        	// 
        	this.comboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboPorts.FormattingEnabled = true;
        	this.comboPorts.Location = new System.Drawing.Point(566, 11);
        	this.comboPorts.Name = "comboPorts";
        	this.comboPorts.Size = new System.Drawing.Size(67, 21);
        	this.comboPorts.TabIndex = 6;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(525, 11);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(35, 21);
        	this.label1.TabIndex = 8;
        	this.label1.Text = "Port:";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// buttonConnect
        	// 
        	this.buttonConnect.Location = new System.Drawing.Point(640, 10);
        	this.buttonConnect.Name = "buttonConnect";
        	this.buttonConnect.Size = new System.Drawing.Size(75, 23);
        	this.buttonConnect.TabIndex = 8;
        	this.buttonConnect.Text = "Connect";
        	this.buttonConnect.UseVisualStyleBackColor = true;
        	this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
        	// 
        	// buttonPortsRefresh
        	// 
        	this.buttonPortsRefresh.Location = new System.Drawing.Point(640, 39);
        	this.buttonPortsRefresh.Name = "buttonPortsRefresh";
        	this.buttonPortsRefresh.Size = new System.Drawing.Size(75, 23);
        	this.buttonPortsRefresh.TabIndex = 9;
        	this.buttonPortsRefresh.Text = "Refresh";
        	this.buttonPortsRefresh.UseVisualStyleBackColor = true;
        	this.buttonPortsRefresh.Click += new System.EventHandler(this.ButtonPortsRefreshClick);
        	// 
        	// backgroundWorker
        	// 
        	this.backgroundWorker.WorkerReportsProgress = true;
        	this.backgroundWorker.WorkerSupportsCancellation = true;
        	this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
        	this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
        	this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
        	// 
        	// comboJoysticks
        	// 
        	this.comboJoysticks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboJoysticks.FormattingEnabled = true;
        	this.comboJoysticks.Location = new System.Drawing.Point(360, 12);
        	this.comboJoysticks.Name = "comboJoysticks";
        	this.comboJoysticks.Size = new System.Drawing.Size(72, 21);
        	this.comboJoysticks.TabIndex = 4;
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(276, 12);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(78, 21);
        	this.label3.TabIndex = 13;
        	this.label3.Text = "vJoy instance:";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// comboProfiles
        	// 
        	this.comboProfiles.FormattingEnabled = true;
        	this.comboProfiles.Location = new System.Drawing.Point(55, 9);
        	this.comboProfiles.Name = "comboProfiles";
        	this.comboProfiles.Size = new System.Drawing.Size(99, 21);
        	this.comboProfiles.TabIndex = 0;
        	// 
        	// buttonLoadProfile
        	// 
        	this.buttonLoadProfile.Location = new System.Drawing.Point(13, 38);
        	this.buttonLoadProfile.Name = "buttonLoadProfile";
        	this.buttonLoadProfile.Size = new System.Drawing.Size(40, 20);
        	this.buttonLoadProfile.TabIndex = 1;
        	this.buttonLoadProfile.Text = "Load";
        	this.buttonLoadProfile.UseVisualStyleBackColor = true;
        	this.buttonLoadProfile.Click += new System.EventHandler(this.ButtonLoadProfileClick);
        	// 
        	// buttonSaveProfile
        	// 
        	this.buttonSaveProfile.Location = new System.Drawing.Point(59, 38);
        	this.buttonSaveProfile.Name = "buttonSaveProfile";
        	this.buttonSaveProfile.Size = new System.Drawing.Size(40, 20);
        	this.buttonSaveProfile.TabIndex = 2;
        	this.buttonSaveProfile.Text = "Save";
        	this.buttonSaveProfile.UseVisualStyleBackColor = true;
        	this.buttonSaveProfile.Click += new System.EventHandler(this.ButtonSaveProfileClick);
        	// 
        	// buttonDeleteProfile
        	// 
        	this.buttonDeleteProfile.Location = new System.Drawing.Point(105, 38);
        	this.buttonDeleteProfile.Name = "buttonDeleteProfile";
        	this.buttonDeleteProfile.Size = new System.Drawing.Size(49, 20);
        	this.buttonDeleteProfile.TabIndex = 3;
        	this.buttonDeleteProfile.Text = "Delete";
        	this.buttonDeleteProfile.UseVisualStyleBackColor = true;
        	this.buttonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteProfileClick);
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(13, 9);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(41, 21);
        	this.label4.TabIndex = 18;
        	this.label4.Text = "Profile:";
        	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// label5
        	// 
        	this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.label5.Location = new System.Drawing.Point(13, 68);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(702, 2);
        	this.label5.TabIndex = 19;
        	this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripStatusLabel});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 500);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(730, 22);
        	this.statusStrip1.SizingGrip = false;
        	this.statusStrip1.TabIndex = 20;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// toolStripStatusLabel
        	// 
        	this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        	this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
        	this.toolStripStatusLabel.Text = "toolStripStatusLabel";
        	// 
        	// label6
        	// 
        	this.label6.Location = new System.Drawing.Point(276, 39);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(78, 21);
        	this.label6.TabIndex = 21;
        	this.label6.Text = "Protocol:";
        	this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// comboProtocol
        	// 
        	this.comboProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboProtocol.FormattingEnabled = true;
        	this.comboProtocol.Items.AddRange(new object[] {
        	        	        	"IBUS",
        	        	        	"MultiWii",
        	        	        	"SBUS"});
        	this.comboProtocol.Location = new System.Drawing.Point(360, 39);
        	this.comboProtocol.Name = "comboProtocol";
        	this.comboProtocol.Size = new System.Drawing.Size(72, 21);
        	this.comboProtocol.TabIndex = 5;
        	this.comboProtocol.SelectedIndexChanged += new System.EventHandler(this.ComboProtocolSelectedIndexChanged);
        	// 
        	// buttonMonitor
        	// 
        	this.buttonMonitor.Location = new System.Drawing.Point(520, 81);
        	this.buttonMonitor.Name = "buttonMonitor";
        	this.buttonMonitor.Size = new System.Drawing.Size(114, 23);
        	this.buttonMonitor.TabIndex = 13;
        	this.buttonMonitor.Text = "Channel Monitor";
        	this.buttonMonitor.UseVisualStyleBackColor = true;
        	this.buttonMonitor.Click += new System.EventHandler(this.ButtonMonitorClick);
        	// 
        	// buttonBitmappedButton
        	// 
        	this.buttonBitmappedButton.Location = new System.Drawing.Point(166, 81);
        	this.buttonBitmappedButton.Name = "buttonBitmappedButton";
        	this.buttonBitmappedButton.Size = new System.Drawing.Size(133, 23);
        	this.buttonBitmappedButton.TabIndex = 12;
        	this.buttonBitmappedButton.Text = "Add Bit-mapped Button";
        	this.buttonBitmappedButton.UseVisualStyleBackColor = true;
        	this.buttonBitmappedButton.Click += new System.EventHandler(this.ButtonBitmappedButtonClick);
        	// 
        	// buttonPortSetup
        	// 
        	this.buttonPortSetup.Location = new System.Drawing.Point(566, 39);
        	this.buttonPortSetup.Name = "buttonPortSetup";
        	this.buttonPortSetup.Size = new System.Drawing.Size(68, 23);
        	this.buttonPortSetup.TabIndex = 7;
        	this.buttonPortSetup.Text = "Port Setup";
        	this.buttonPortSetup.UseVisualStyleBackColor = true;
        	this.buttonPortSetup.Click += new System.EventHandler(this.ButtonPortSetupClick);
        	// 
        	// buttonProtocolSetup
        	// 
        	this.buttonProtocolSetup.Location = new System.Drawing.Point(439, 38);
        	this.buttonProtocolSetup.Name = "buttonProtocolSetup";
        	this.buttonProtocolSetup.Size = new System.Drawing.Size(46, 23);
        	this.buttonProtocolSetup.TabIndex = 22;
        	this.buttonProtocolSetup.Text = "Setup";
        	this.buttonProtocolSetup.UseVisualStyleBackColor = true;
        	this.buttonProtocolSetup.Click += new System.EventHandler(this.ButtonProtocolSetupClick);
        	// 
        	// buttonHelp
        	// 
        	this.buttonHelp.Location = new System.Drawing.Point(640, 81);
        	this.buttonHelp.Name = "buttonHelp";
        	this.buttonHelp.Size = new System.Drawing.Size(75, 23);
        	this.buttonHelp.TabIndex = 23;
        	this.buttonHelp.Text = "Help";
        	this.buttonHelp.UseVisualStyleBackColor = true;
        	this.buttonHelp.Click += new System.EventHandler(this.ButtonHelpClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(730, 522);
        	this.Controls.Add(this.buttonHelp);
        	this.Controls.Add(this.buttonProtocolSetup);
        	this.Controls.Add(this.buttonPortSetup);
        	this.Controls.Add(this.buttonBitmappedButton);
        	this.Controls.Add(this.buttonMonitor);
        	this.Controls.Add(this.comboProtocol);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.buttonDeleteProfile);
        	this.Controls.Add(this.buttonSaveProfile);
        	this.Controls.Add(this.buttonLoadProfile);
        	this.Controls.Add(this.comboProfiles);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.comboJoysticks);
        	this.Controls.Add(this.buttonPortsRefresh);
        	this.Controls.Add(this.buttonConnect);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.comboPorts);
        	this.Controls.Add(this.buttonAddButton);
        	this.Controls.Add(this.buttonAddAxis);
        	this.Controls.Add(this.panelMappings);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Icon = global::vJoySerialFeeder.Resources.Joystick_icon;
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "vJoySerialFeeder";
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonProtocolSetup;
        private System.Windows.Forms.Button buttonPortSetup;
        private System.Windows.Forms.Button buttonBitmappedButton;
        private System.Windows.Forms.Button buttonMonitor;
        private System.Windows.Forms.ComboBox comboProtocol;
        private System.Windows.Forms.Label label6;
	}
}
