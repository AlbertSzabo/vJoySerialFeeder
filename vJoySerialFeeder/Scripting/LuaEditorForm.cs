﻿/*
 * Created by SharpDevelop.
 * User: Cleric
 * Date: 27.3.2018 г.
 * Time: 15:07 ч.
 */
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using MoonSharp.Interpreter;

namespace vJoySerialFeeder
{
	/// <summary>
	/// Description of LuaEditorForm.
	/// </summary>
	public partial class LuaEditorForm : Form
	{
		public string ScriptSource {get; private set; }
		
		string originalScript;
		
		public LuaEditorForm(string script)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if(script == null || script.Trim().Length == 0) {
				script = Resources.script_template;
			}
			
			originalScript = script;
			editorBox.Text = script;
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			if(testCompile()) {
				originalScript = ScriptSource = editorBox.Text;
				DialogResult = DialogResult.OK;
			}
		}
		
		void ButtonTestCompileClick(object sender, EventArgs e)
		{
			if(testCompile())
				MessageBox.Show("Script compiled successfully");
		}
		
		bool testCompile() {
			try {
				var lua = new Lua(editorBox.Text);
				lua.Test();
			}
			catch(InterpreterException ex) {
				MessageBox.Show(ex.DecoratedMessage);
				return false;
			}
			return true;
		}
		
		void CMenuOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			mCopy.Enabled = mCut.Enabled = !editorBox.Selection.IsEmpty;
			mUndo.Enabled = editorBox.UndoEnabled;
			mRedo.Enabled = editorBox.RedoEnabled;
		}
		
		void LuaEditorFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(DialogResult != DialogResult.Abort && editorBox.Text != originalScript) {
				if(MessageBox.Show("Discard changes?", "Script modified", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					e.Cancel = true;
			}
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Abort;
		}
	}

}
