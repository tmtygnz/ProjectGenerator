
namespace ProjectGenerator
{
	partial class MainWindow
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
			this.CMDBool = new System.Windows.Forms.CheckBox();
			this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editGeneratorPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenExp = new System.Windows.Forms.CheckBox();
			this.graph = new DarkUI.Controls.DarkButton();
			this.path = new DarkUI.Controls.DarkTextBox();
			this.ChangePath = new DarkUI.Controls.DarkButton();
			this.darkMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LangSlect
			// 
			this.LangSlect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LangSlect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.LangSlect.FormattingEnabled = true;
			this.LangSlect.Location = new System.Drawing.Point(12, 62);
			this.LangSlect.Name = "LangSlect";
			this.LangSlect.Size = new System.Drawing.Size(167, 24);
			this.LangSlect.TabIndex = 0;
			this.LangSlect.SelectedIndexChanged += new System.EventHandler(this.LangSlect_SelectedIndexChanged);
			// 
			// darkLabel1
			// 
			this.darkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(184, 63);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(65, 17);
			this.darkLabel1.TabIndex = 2;
			this.darkLabel1.Text = "Language";
			// 
			// CMDBool
			// 
			this.CMDBool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CMDBool.AutoSize = true;
			this.CMDBool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CMDBool.Location = new System.Drawing.Point(12, 96);
			this.CMDBool.Name = "CMDBool";
			this.CMDBool.Size = new System.Drawing.Size(85, 19);
			this.CMDBool.TabIndex = 3;
			this.CMDBool.Text = "Open CMD";
			this.CMDBool.UseVisualStyleBackColor = true;
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
			// editGeneratorPreferencesToolStripMenuItem
			// 
			this.editGeneratorPreferencesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.editGeneratorPreferencesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.editGeneratorPreferencesToolStripMenuItem.Name = "editGeneratorPreferencesToolStripMenuItem";
			this.editGeneratorPreferencesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.editGeneratorPreferencesToolStripMenuItem.Text = "Edit Generator Preferences";
			this.editGeneratorPreferencesToolStripMenuItem.Click += new System.EventHandler(this.editGeneratorPreferencesToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// OpenExp
			// 
			this.OpenExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenExp.AutoSize = true;
			this.OpenExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.OpenExp.Location = new System.Drawing.Point(12, 121);
			this.OpenExp.Name = "OpenExp";
			this.OpenExp.Size = new System.Drawing.Size(114, 19);
			this.OpenExp.TabIndex = 8;
			this.OpenExp.Text = "Open In Explorer";
			this.OpenExp.UseVisualStyleBackColor = true;
			// 
			// graph
			// 
			this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.graph.Location = new System.Drawing.Point(139, 96);
			this.graph.Name = "graph";
			this.graph.Padding = new System.Windows.Forms.Padding(5);
			this.graph.Size = new System.Drawing.Size(118, 44);
			this.graph.TabIndex = 9;
			this.graph.Text = "Generate";
			this.graph.Click += new System.EventHandler(this.graph_Click);
			// 
			// path
			// 
			this.path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.path.Location = new System.Drawing.Point(12, 33);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(167, 23);
			this.path.TabIndex = 10;
			// 
			// ChangePath
			// 
			this.ChangePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ChangePath.Location = new System.Drawing.Point(187, 35);
			this.ChangePath.Name = "ChangePath";
			this.ChangePath.Padding = new System.Windows.Forms.Padding(5);
			this.ChangePath.Size = new System.Drawing.Size(62, 21);
			this.ChangePath.TabIndex = 11;
			this.ChangePath.Text = "Path";
			this.ChangePath.Click += new System.EventHandler(this.path_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(269, 152);
			this.Controls.Add(this.ChangePath);
			this.Controls.Add(this.path);
			this.Controls.Add(this.graph);
			this.Controls.Add(this.OpenExp);
			this.Controls.Add(this.darkMenuStrip1);
			this.Controls.Add(this.CMDBool);
			this.Controls.Add(this.darkLabel1);
			this.Controls.Add(this.LangSlect);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainWindow";
			this.Text = "ProjectGenerator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DarkUI.Controls.DarkComboBox LangSlect;
		private DarkUI.Controls.DarkLabel darkLabel1;
		private System.Windows.Forms.CheckBox CMDBool;
		private DarkUI.Controls.DarkContextMenu darkContextMenu1;
		private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editGeneratorPreferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.CheckBox OpenExp;
		private DarkUI.Controls.DarkButton graph;
		private DarkUI.Controls.DarkTextBox path;
		private DarkUI.Controls.DarkButton ChangePath;
	}
}

