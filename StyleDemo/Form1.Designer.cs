﻿namespace StyleDemo {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lStyleName = new System.Windows.Forms.Label();
			this.lSignature = new System.Windows.Forms.Label();
			this.lMetronomeMark = new System.Windows.Forms.Label();
			this.lTempo = new System.Windows.Forms.Label();
			this.gbStyleInfo = new System.Windows.Forms.GroupBox();
			this.lwMessages = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.btnPlay = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pbBeat = new StyleDemo.CustomProgressBar();
			this.menuStrip1.SuspendLayout();
			this.gbStyleInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(579, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// lStyleName
			// 
			this.lStyleName.AutoSize = true;
			this.lStyleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lStyleName.Location = new System.Drawing.Point(6, 15);
			this.lStyleName.Name = "lStyleName";
			this.lStyleName.Size = new System.Drawing.Size(148, 20);
			this.lStyleName.TabIndex = 1;
			this.lStyleName.Text = "Nincs stílus betöltve";
			// 
			// lSignature
			// 
			this.lSignature.AutoSize = true;
			this.lSignature.Location = new System.Drawing.Point(6, 39);
			this.lSignature.Name = "lSignature";
			this.lSignature.Size = new System.Drawing.Size(106, 13);
			this.lSignature.TabIndex = 2;
			this.lSignature.Text = "Ismeretlen szignatúra";
			// 
			// lMetronomeMark
			// 
			this.lMetronomeMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lMetronomeMark.Location = new System.Drawing.Point(488, 13);
			this.lMetronomeMark.Name = "lMetronomeMark";
			this.lMetronomeMark.Size = new System.Drawing.Size(61, 13);
			this.lMetronomeMark.TabIndex = 3;
			this.lMetronomeMark.Text = "0/0";
			this.lMetronomeMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lTempo
			// 
			this.lTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lTempo.Location = new System.Drawing.Point(485, 30);
			this.lTempo.Name = "lTempo";
			this.lTempo.Size = new System.Drawing.Size(64, 13);
			this.lTempo.TabIndex = 4;
			this.lTempo.Text = "0 BPM";
			this.lTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbStyleInfo
			// 
			this.gbStyleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbStyleInfo.Controls.Add(this.lStyleName);
			this.gbStyleInfo.Controls.Add(this.lTempo);
			this.gbStyleInfo.Controls.Add(this.lSignature);
			this.gbStyleInfo.Controls.Add(this.lMetronomeMark);
			this.gbStyleInfo.Location = new System.Drawing.Point(12, 27);
			this.gbStyleInfo.Name = "gbStyleInfo";
			this.gbStyleInfo.Size = new System.Drawing.Size(555, 65);
			this.gbStyleInfo.TabIndex = 5;
			this.gbStyleInfo.TabStop = false;
			this.gbStyleInfo.Text = "Stílus";
			// 
			// lwMessages
			// 
			this.lwMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lwMessages.FullRowSelect = true;
			this.lwMessages.Location = new System.Drawing.Point(12, 142);
			this.lwMessages.Name = "lwMessages";
			this.lwMessages.Size = new System.Drawing.Size(555, 209);
			this.lwMessages.TabIndex = 6;
			this.lwMessages.UseCompatibleStateImageBehavior = false;
			this.lwMessages.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Idő";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Típus";
			this.columnHeader1.Width = 88;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Csatorna";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Adat1";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Adat2";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Adat3";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Intro",
            "Original",
            "Variation",
            "Variation2",
            "Fill to Variation",
            "Fill to Variation2",
            "Fill to Original",
            "Ending"});
			this.comboBox1.Location = new System.Drawing.Point(125, 98);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Enabled = false;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Basic",
            "Advanced"});
			this.comboBox2.Location = new System.Drawing.Point(12, 98);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(107, 21);
			this.comboBox2.TabIndex = 8;
			this.comboBox2.SelectedIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Enabled = false;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "Drum",
            "Bass",
            "Acc1",
            "Acc2",
            "Acc3",
            "Acc4",
            "Acc5",
            "Acc6"});
			this.comboBox3.Location = new System.Drawing.Point(252, 98);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(68, 21);
			this.comboBox3.TabIndex = 9;
			this.comboBox3.SelectedIndex = 0;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.Enabled = false;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Items.AddRange(new object[] {
            "Major",
            "Minor",
            "7th"});
			this.comboBox4.Location = new System.Drawing.Point(326, 98);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(73, 21);
			this.comboBox4.TabIndex = 10;
			this.comboBox4.SelectedIndex = 0;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// btnPlay
			// 
			this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlay.Enabled = false;
			this.btnPlay.Location = new System.Drawing.Point(492, 96);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 11;
			this.btnPlay.Text = "Lejátszás";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(405, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "0:0:0 (0)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pbBeat
			// 
			this.pbBeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbBeat.BackColor = System.Drawing.Color.White;
			this.pbBeat.ForeColor = System.Drawing.Color.Green;
			this.pbBeat.Location = new System.Drawing.Point(492, 125);
			this.pbBeat.Maximum = 100;
			this.pbBeat.Minimum = 0;
			this.pbBeat.Name = "pbBeat";
			this.pbBeat.Size = new System.Drawing.Size(75, 10);
			this.pbBeat.TabIndex = 13;
			this.pbBeat.Value = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 363);
			this.Controls.Add(this.pbBeat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lwMessages);
			this.Controls.Add(this.gbStyleInfo);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "TomiSoft Roland Style Reader";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbStyleInfo.ResumeLayout(false);
			this.gbStyleInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Label lStyleName;
		private System.Windows.Forms.Label lSignature;
		private System.Windows.Forms.Label lMetronomeMark;
		private System.Windows.Forms.Label lTempo;
		private System.Windows.Forms.GroupBox gbStyleInfo;
		private System.Windows.Forms.ListView lwMessages;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label label1;
		private CustomProgressBar pbBeat;
	}
}

