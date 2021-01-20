
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
			this.SuspendLayout();
			// 
			// LangSlect
			// 
			this.LangSlect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.LangSlect.FormattingEnabled = true;
			this.LangSlect.Location = new System.Drawing.Point(12, 12);
			this.LangSlect.Name = "LangSlect";
			this.LangSlect.Size = new System.Drawing.Size(121, 21);
			this.LangSlect.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LangSlect);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private DarkUI.Controls.DarkComboBox LangSlect;
	}
}

