namespace Nahravadlo
{
	partial class formMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
			this.lst = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dteEnd = new System.Windows.Forms.DateTimePicker();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdAdd = new System.Windows.Forms.Button();
			this.cmdBrowse = new System.Windows.Forms.Button();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numLength = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.dteBegin = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbProgram = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recordNowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.numLength)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lst
			// 
			this.lst.FormattingEnabled = true;
			this.lst.Location = new System.Drawing.Point(12, 27);
			this.lst.Name = "lst";
			this.lst.Size = new System.Drawing.Size(228, 225);
			this.lst.Sorted = true;
			this.lst.TabIndex = 0;
			this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dteEnd);
			this.groupBox1.Controls.Add(this.txtStatus);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cmdDelete);
			this.groupBox1.Controls.Add(this.cmdSave);
			this.groupBox1.Controls.Add(this.cmdAdd);
			this.groupBox1.Controls.Add(this.cmdBrowse);
			this.groupBox1.Controls.Add(this.txtFilename);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.numLength);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dteBegin);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbProgram);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(254, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(447, 222);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informace o nahr�v�n�";
			// 
			// dteEnd
			// 
			this.dteEnd.CustomFormat = "dd. MM. yyyy - HH:mm";
			this.dteEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dteEnd.Location = new System.Drawing.Point(311, 101);
			this.dteEnd.Name = "dteEnd";
			this.dteEnd.Size = new System.Drawing.Size(130, 20);
			this.dteEnd.TabIndex = 17;
			this.dteEnd.ValueChanged += new System.EventHandler(this.dteEnd_ValueChanged);
			this.dteEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dteEnd_Validating);
			// 
			// txtStatus
			// 
			this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
			this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtStatus.Location = new System.Drawing.Point(167, 156);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(274, 13);
			this.txtStatus.TabIndex = 16;
			this.txtStatus.Text = "Nahr�v�n� nebylo je�t� zalo�eno.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Stav nahr�v�n�:";
			// 
			// cmdDelete
			// 
			this.cmdDelete.Enabled = false;
			this.cmdDelete.Location = new System.Drawing.Point(113, 190);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(101, 26);
			this.cmdDelete.TabIndex = 14;
			this.cmdDelete.Text = "Smazat";
			this.cmdDelete.UseVisualStyleBackColor = true;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.Enabled = false;
			this.cmdSave.Location = new System.Drawing.Point(340, 190);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(101, 26);
			this.cmdSave.TabIndex = 13;
			this.cmdSave.Text = "Ulo�it";
			this.cmdSave.UseVisualStyleBackColor = true;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdAdd
			// 
			this.cmdAdd.Enabled = false;
			this.cmdAdd.Location = new System.Drawing.Point(6, 190);
			this.cmdAdd.Name = "cmdAdd";
			this.cmdAdd.Size = new System.Drawing.Size(101, 26);
			this.cmdAdd.TabIndex = 12;
			this.cmdAdd.Text = "P�idat";
			this.cmdAdd.UseVisualStyleBackColor = true;
			this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
			// 
			// cmdBrowse
			// 
			this.cmdBrowse.Location = new System.Drawing.Point(407, 126);
			this.cmdBrowse.Name = "cmdBrowse";
			this.cmdBrowse.Size = new System.Drawing.Size(34, 22);
			this.cmdBrowse.TabIndex = 11;
			this.cmdBrowse.Text = "...";
			this.cmdBrowse.UseVisualStyleBackColor = true;
			this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
			// 
			// txtFilename
			// 
			this.txtFilename.Location = new System.Drawing.Point(167, 127);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(234, 20);
			this.txtFilename.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Ulo�it do souboru:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(167, 22);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(274, 20);
			this.txtName.TabIndex = 8;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "N�zev nahr�v�n�:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(225, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "minut, nebo do:";
			// 
			// numLength
			// 
			this.numLength.Location = new System.Drawing.Point(167, 101);
			this.numLength.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLength.Name = "numLength";
			this.numLength.Size = new System.Drawing.Size(52, 20);
			this.numLength.TabIndex = 5;
			this.numLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLength.ValueChanged += new System.EventHandler(this.numLength_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "D�lka po�adu:";
			// 
			// dteBegin
			// 
			this.dteBegin.CustomFormat = "dd. MM. yyyy - HH:mm";
			this.dteBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dteBegin.Location = new System.Drawing.Point(167, 75);
			this.dteBegin.Name = "dteBegin";
			this.dteBegin.Size = new System.Drawing.Size(274, 20);
			this.dteBegin.TabIndex = 3;
			this.dteBegin.ValueChanged += new System.EventHandler(this.dteBegin_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Datum a �as za��tku po�adu:";
			// 
			// cmbProgram
			// 
			this.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProgram.FormattingEnabled = true;
			this.cmbProgram.Location = new System.Drawing.Point(167, 48);
			this.cmbProgram.Name = "cmbProgram";
			this.cmbProgram.Size = new System.Drawing.Size(274, 21);
			this.cmbProgram.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kan�l / Stanice:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.optionMenuItem,
            this.recordNowMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(713, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(64, 20);
			this.aboutMenuItem.Text = "O aplikaci";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// optionMenuItem
			// 
			this.optionMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.optionMenuItem.Name = "optionMenuItem";
			this.optionMenuItem.Size = new System.Drawing.Size(67, 20);
			this.optionMenuItem.Text = "Nastaven�";
			this.optionMenuItem.Click += new System.EventHandler(this.optionMenuItem_Click);
			// 
			// recordNowMenuItem
			// 
			this.recordNowMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.recordNowMenuItem.Name = "recordNowMenuItem";
			this.recordNowMenuItem.Size = new System.Drawing.Size(114, 20);
			this.recordNowMenuItem.Text = "Okam�it� nahr�v�n�";
			this.recordNowMenuItem.Click += new System.EventHandler(this.RecordNowMenuItem_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 261);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lst);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "formMain";
			this.Text = "Nahr�vadlo x.x.x by Arcao";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.numLength)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lst;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dteBegin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbProgram;
		private System.Windows.Forms.NumericUpDown numLength;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button cmdBrowse;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Button cmdAdd;
		private System.Windows.Forms.SaveFileDialog dialog;
		private System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem optionMenuItem;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ToolStripMenuItem recordNowMenuItem;
		private System.Windows.Forms.DateTimePicker dteEnd;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
	}
}

