namespace HexDevide
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			statusStrip1 = new StatusStrip();
			lblDateTime = new ToolStripStatusLabel();
			lblCharacters = new ToolStripStatusLabel();
			tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
			btnAscii2Hex = new DevExpress.XtraEditors.SimpleButton();
			btnHex2Ascii = new DevExpress.XtraEditors.SimpleButton();
			txtAscii = new RichTextBox();
			txtHex = new RichTextBox();
			labelControl2 = new DevExpress.XtraEditors.LabelControl();
			labelControl1 = new DevExpress.XtraEditors.LabelControl();
			dgvCharacterList = new DataGridView();
			HexCode = new DataGridViewTextBoxColumn();
			ASCIIChar = new DataGridViewTextBoxColumn();
			NoOfChar = new DataGridViewTextBoxColumn();
			statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
			tablePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
			tablePanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tablePanel3).BeginInit();
			tablePanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCharacterList).BeginInit();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { lblDateTime, lblCharacters });
			statusStrip1.Location = new Point(0, 696);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(998, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "statusStrip1";
			// 
			// lblDateTime
			// 
			lblDateTime.Name = "lblDateTime";
			lblDateTime.Size = new Size(118, 17);
			lblDateTime.Text = "toolStripStatusLabel1";
			// 
			// lblCharacters
			// 
			lblCharacters.Name = "lblCharacters";
			lblCharacters.Size = new Size(73, 17);
			lblCharacters.Text = "Charachters:";
			// 
			// tablePanel1
			// 
			tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F) });
			tablePanel1.Controls.Add(tablePanel2);
			tablePanel1.Controls.Add(dgvCharacterList);
			tablePanel1.Dock = DockStyle.Fill;
			tablePanel1.Location = new Point(0, 0);
			tablePanel1.Name = "tablePanel1";
			tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F) });
			tablePanel1.Size = new Size(998, 696);
			tablePanel1.TabIndex = 1;
			tablePanel1.UseSkinIndents = true;
			// 
			// tablePanel2
			// 
			tablePanel1.SetColumn(tablePanel2, 0);
			tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F) });
			tablePanel2.Controls.Add(tablePanel3);
			tablePanel2.Controls.Add(txtAscii);
			tablePanel2.Controls.Add(txtHex);
			tablePanel2.Controls.Add(labelControl2);
			tablePanel2.Controls.Add(labelControl1);
			tablePanel2.Dock = DockStyle.Fill;
			tablePanel2.Location = new Point(11, 10);
			tablePanel2.Margin = new Padding(0);
			tablePanel2.Name = "tablePanel2";
			tablePanel1.SetRow(tablePanel2, 0);
			tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F) });
			tablePanel2.Size = new Size(710, 675);
			tablePanel2.TabIndex = 6;
			// 
			// tablePanel3
			// 
			tablePanel2.SetColumn(tablePanel3, 0);
			tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F) });
			tablePanel3.Controls.Add(btnAscii2Hex);
			tablePanel3.Controls.Add(btnHex2Ascii);
			tablePanel3.Dock = DockStyle.Fill;
			tablePanel3.Location = new Point(0, 318);
			tablePanel3.Margin = new Padding(0);
			tablePanel3.Name = "tablePanel3";
			tablePanel2.SetRow(tablePanel3, 2);
			tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F) });
			tablePanel3.Size = new Size(710, 40);
			tablePanel3.TabIndex = 4;
			// 
			// btnAscii2Hex
			// 
			btnAscii2Hex.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
			btnAscii2Hex.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnAscii2Hex.Appearance.Options.UseBackColor = true;
			btnAscii2Hex.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(btnAscii2Hex, 1);
			btnAscii2Hex.Dock = DockStyle.Fill;
			btnAscii2Hex.Location = new Point(358, 3);
			btnAscii2Hex.Name = "btnAscii2Hex";
			tablePanel3.SetRow(btnAscii2Hex, 0);
			btnAscii2Hex.Size = new Size(349, 34);
			btnAscii2Hex.TabIndex = 1;
			btnAscii2Hex.Text = "↑  Convert ASCII to Hex  ↑";
			btnAscii2Hex.Click += btnAscii2Hex_Click;
			// 
			// btnHex2Ascii
			// 
			btnHex2Ascii.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
			btnHex2Ascii.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
			btnHex2Ascii.Appearance.Options.UseBackColor = true;
			btnHex2Ascii.Appearance.Options.UseFont = true;
			tablePanel3.SetColumn(btnHex2Ascii, 0);
			btnHex2Ascii.Dock = DockStyle.Fill;
			btnHex2Ascii.Location = new Point(3, 3);
			btnHex2Ascii.Name = "btnHex2Ascii";
			tablePanel3.SetRow(btnHex2Ascii, 0);
			btnHex2Ascii.Size = new Size(349, 34);
			btnHex2Ascii.TabIndex = 0;
			btnHex2Ascii.Text = "↓  Convert Hex to ASCII  ↓";
			btnHex2Ascii.Click += btnHex2Ascii_Click;
			// 
			// txtAscii
			// 
			tablePanel2.SetColumn(txtAscii, 0);
			txtAscii.Dock = DockStyle.Fill;
			txtAscii.Location = new Point(3, 381);
			txtAscii.Name = "txtAscii";
			tablePanel2.SetRow(txtAscii, 4);
			txtAscii.Size = new Size(704, 291);
			txtAscii.TabIndex = 3;
			txtAscii.Text = "";
			// 
			// txtHex
			// 
			tablePanel2.SetColumn(txtHex, 0);
			txtHex.Dock = DockStyle.Fill;
			txtHex.Location = new Point(3, 23);
			txtHex.Name = "txtHex";
			tablePanel2.SetRow(txtHex, 1);
			txtHex.Size = new Size(704, 292);
			txtHex.TabIndex = 2;
			txtHex.Text = "";
			txtHex.KeyPress += txtHex_KeyPress;
			// 
			// labelControl2
			// 
			labelControl2.Appearance.BackColor = Color.FromArgb(192, 192, 255);
			labelControl2.Appearance.Options.UseBackColor = true;
			labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			tablePanel2.SetColumn(labelControl2, 0);
			labelControl2.Dock = DockStyle.Fill;
			labelControl2.Location = new Point(3, 361);
			labelControl2.Name = "labelControl2";
			tablePanel2.SetRow(labelControl2, 3);
			labelControl2.Size = new Size(704, 14);
			labelControl2.TabIndex = 1;
			labelControl2.Text = "ASCII Characters:";
			// 
			// labelControl1
			// 
			labelControl1.Appearance.BackColor = Color.FromArgb(128, 128, 255);
			labelControl1.Appearance.Options.UseBackColor = true;
			labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			tablePanel2.SetColumn(labelControl1, 0);
			labelControl1.Dock = DockStyle.Fill;
			labelControl1.Location = new Point(3, 3);
			labelControl1.Name = "labelControl1";
			tablePanel2.SetRow(labelControl1, 0);
			labelControl1.Size = new Size(704, 14);
			labelControl1.TabIndex = 0;
			labelControl1.Text = "Hexadecimal Codes:";
			// 
			// dgvCharacterList
			// 
			dgvCharacterList.AllowUserToAddRows = false;
			dgvCharacterList.AllowUserToDeleteRows = false;
			tablePanel1.SetColumn(dgvCharacterList, 1);
			dgvCharacterList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCharacterList.Columns.AddRange(new DataGridViewColumn[] { HexCode, ASCIIChar, NoOfChar });
			dgvCharacterList.Dock = DockStyle.Fill;
			dgvCharacterList.Location = new Point(721, 10);
			dgvCharacterList.Margin = new Padding(0);
			dgvCharacterList.Name = "dgvCharacterList";
			dgvCharacterList.ReadOnly = true;
			tablePanel1.SetRow(dgvCharacterList, 0);
			dgvCharacterList.RowHeadersVisible = false;
			dgvCharacterList.RowTemplate.Height = 25;
			dgvCharacterList.Size = new Size(266, 675);
			dgvCharacterList.TabIndex = 5;
			// 
			// HexCode
			// 
			HexCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			HexCode.HeaderText = "HexCode";
			HexCode.Name = "HexCode";
			HexCode.ReadOnly = true;
			// 
			// ASCIIChar
			// 
			ASCIIChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			ASCIIChar.HeaderText = "ASCII Char";
			ASCIIChar.Name = "ASCIIChar";
			ASCIIChar.ReadOnly = true;
			// 
			// NoOfChar
			// 
			NoOfChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			NoOfChar.HeaderText = "Number Of Char";
			NoOfChar.Name = "NoOfChar";
			NoOfChar.ReadOnly = true;
			// 
			// frmMain
			// 
			Appearance.Options.UseTextOptions = true;
			Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(998, 718);
			Controls.Add(tablePanel1);
			Controls.Add(statusStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			IconOptions.Icon = (Icon)resources.GetObject("frmMain.IconOptions.Icon");
			MaximizeBox = false;
			Name = "frmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hex2ASCII";
			FormClosing += frmMain_FormClosing;
			Load += frmMain_Load;
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
			tablePanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
			tablePanel2.ResumeLayout(false);
			tablePanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tablePanel3).EndInit();
			tablePanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvCharacterList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		private ToolStripStatusLabel lblCharacters;
		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DataGridView dgvCharacterList;
		private DataGridViewTextBoxColumn HexCode;
		private DataGridViewTextBoxColumn ASCIIChar;
		private DataGridViewTextBoxColumn NoOfChar;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.Utils.Layout.TablePanel tablePanel3;
		private RichTextBox txtAscii;
		private RichTextBox txtHex;
		private DevExpress.XtraEditors.SimpleButton btnAscii2Hex;
		private DevExpress.XtraEditors.SimpleButton btnHex2Ascii;
		private ToolStripStatusLabel lblDateTime;
	}
}