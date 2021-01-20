
namespace ProjectGenerator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LangSlect = new DarkUI.Controls.DarkComboBox();
			this.darkLabel1 = new DarkUI.Controls.DarkLabel();
			this.GitBool = new System.Windows.Forms.CheckBox();
			this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editGeneratorPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GitURL = new DarkUI.Controls.DarkTextBox();
			this.darkLabel2 = new DarkUI.Controls.DarkLabel();
			this.OpenExp = new System.Windows.Forms.CheckBox();
			this.graph = new DarkUI.Controls.DarkButton();
			this.darkMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LangSlect
			// 
			this.LangSlect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.LangSlect.FormattingEnabled = true;
			this.LangSlect.Location = new System.Drawing.Point(12, 38);
			this.LangSlect.Name = "LangSlect";
			this.LangSlect.Size = new System.Drawing.Size(167, 24);
			this.LangSlect.TabIndex = 0;
			this.LangSlect.SelectedIndexChanged += new System.EventHandler(this.LangSlect_SelectedIndexChanged);
			// 
			// darkLabel1
			// 
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(185, 39);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(65, 17);
			this.darkLabel1.TabIndex = 2;
			this.darkLabel1.Text = "Language";
			// 
			// GitBool
			// 
			this.GitBool.AutoSize = true;
			this.GitBool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.GitBool.Location = new System.Drawing.Point(12, 95);
			this.GitBool.Name = "GitBool";
			this.GitBool.Size = new System.Drawing.Size(106, 19);
			this.GitBool.TabIndex = 3;
			this.GitBool.Text = "Push To Github";
			this.GitBool.UseVisualStyleBackColor = true;
			this.GitBool.CheckedChanged += new System.EventHandler(this.GitBool_CheckedChanged);
			// 
			// darkContextMenu1
			// 
			this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkContextMenu1.Name = "darkContextMenu1";
			this.darkContextMenu1.Size = new System.Drawing.Size(61, 4);
			// 
			// darkMenuStrip1
			// 
			this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.darkMenuStrip1.Name = "darkMenuStrip1";
			this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.darkMenuStrip1.Size = new System.Drawing.Size(269, 24);
			this.darkMenuStrip1.TabIndex = 5;
			this.darkMenuStrip1.Text = "darkMenuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGeneratorPreferencesToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// editGeneratorPreferencesToolStripMenuItem
			// 
			this.editGeneratorPreferencesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.editGeneratorPreferencesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.editGeneratorPreferencesToolStripMenuItem.Name = "editGeneratorPreferencesToolStripMenuItem";
			this.editGeneratorPreferencesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.editGeneratorPreferencesToolStripMenuItem.Text = "Edit Generator Preferences";
			// 
			// GitURL
			// 
			this.GitURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.GitURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GitURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.GitURL.Location = new System.Drawing.Point(12, 66);
			this.GitURL.Name = "GitURL";
			this.GitURL.Size = new System.Drawing.Size(167, 23);
			this.GitURL.TabIndex = 6;
			// 
			// darkLabel2
			// 
			this.darkLabel2.AutoSize = true;
			this.darkLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel2.Location = new System.Drawing.Point(185, 66);
			this.darkLabel2.Name = "darkLabel2";
			this.darkLabel2.Size = new System.Drawing.Size(73, 17);
			this.darkLabel2.TabIndex = 7;
			this.darkLabel2.Text = "Github URL";
			// 
			// OpenExp
			// 
			this.OpenExp.AutoSize = true;
			this.OpenExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.OpenExp.Location = new System.Drawing.Point(12, 120);
			this.OpenExp.Name = "OpenExp";
			this.OpenExp.Size = new System.Drawing.Size(114, 19);
			this.OpenExp.TabIndex = 8;
			this.OpenExp.Text = "Open In Explorer";
			this.OpenExp.UseVisualStyleBackColor = true;
			// 
			// graph
			// 
			this.graph.Location = new System.Drawing.Point(139, 95);
			this.graph.Name = "graph";
			this.graph.Padding = new System.Windows.Forms.Padding(5);
			this.graph.Size = new System.Drawing.Size(118, 44);
			this.graph.TabIndex = 9;
			this.graph.Text = "Generate";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(269, 151);
			this.Controls.Add(this.graph);
			this.Controls.Add(this.OpenExp);
			this.Controls.Add(this.darkLabel2);
			this.Controls.Add(this.GitURL);
			this.Controls.Add(this.darkMenuStrip1);
			this.Controls.Add(this.GitBool);
			this.Controls.Add(this.darkLabel1);
			this.Controls.Add(this.LangSlect);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DarkUI.Controls.DarkComboBox LangSlect;
		private DarkUI.Controls.DarkLabel darkLabel1;
		private System.Windows.Forms.CheckBox GitBool;
		private DarkUI.Controls.DarkContextMenu darkContextMenu1;
		private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editGeneratorPreferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private DarkUI.Controls.DarkTextBox GitURL;
		private DarkUI.Controls.DarkLabel darkLabel2;
		private System.Windows.Forms.CheckBox OpenExp;
		private DarkUI.Controls.DarkButton graph;
	}
}

