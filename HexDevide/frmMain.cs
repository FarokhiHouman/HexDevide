using System.Text;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using Timer = System.Windows.Forms.Timer;


namespace HexDevide;

public partial class frmMain : XtraForm
{
#region Fields and properties
#region Fields
	private readonly Dictionary<char, string> _controlCharNames = new()
																  {
																	  { '\0', "NUL (Null)" },
																	  { '\x01', "SOH (Start of Heading)" },
																	  { '\x02', "STX (Start of Text)" },
																	  { '\x03', "ETX (End of Text)" },
																	  { '\x04', "EOT (End of Transmission)" },
																	  { '\x05', "ENQ (Enquiry)" },
																	  { '\x06', "ACK (Acknowledgment)" },
																	  { '\x07', "BEL (Bell)" },
																	  { '\x08', "BS (Backspace)" },
																	  { '\x09', "HT (Horizontal Tab)" },
																	  { '\x0A', "LF (Line Feed/Newline)" },
																	  { '\x0B', "VT (Vertical Tab)" },
																	  { '\x0C', "FF (Form Feed)" },
																	  { '\x0D', "CR (Carriage Return)" },
																	  { '\x0E', "SO (Shift Out)" },
																	  { '\x0F', "SI (Shift In)" },
																	  { '\x10', "DLE (Data Link Escape)" },
																	  { '\x11', "DC1 (Device Control 1)" },
																	  { '\x12', "DC2 (Device Control 2)" },
																	  { '\x13', "DC3 (Device Control 3)" },
																	  { '\x14', "DC4 (Device Control 4)" },
																	  { '\x15', "NAK (Negative Acknowledgment)" },
																	  { '\x16', "SYN (Synchronous Idle)" },
																	  { '\x17', "ETB (End of Transmission Block)" },
																	  { '\x18', "CAN (Cancel)" },
																	  { '\x19', "EM (End of Medium)" },
																	  { '\x1A', "SUB (Substitute)" },
																	  { '\x1B', "ESC (Escape)" },
																	  { '\x1C', "FS (File Separator)" },
																	  { '\x1D', "GS (Group Separator)" },
																	  { '\x1E', "RS (Record Separator)" },
																	  { '\x1F', "US (Unit Separator)" },
																	  { '\x7F', "DEL (Delete)" }
																  };
	private Timer timer;
#endregion
#endregion
#region Mthods
#region Constractor
	public frmMain()
	{
		InitializeComponent();
		dgvCharacterList.CellFormatting += DataGridView1_CellFormatting; // Subscribe to the CellFormatting event
	}
#endregion
#region Other
	private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex < 0) return;
		string? hexValue  = dgvCharacterList.Rows[index: e.RowIndex].Cells[columnName: "HexCode"].Value.ToString();
		char    asciiChar = Convert.ToChar(value: Convert.ToUInt32(value: hexValue, fromBase: 16));

		// Determine the character type
		if (char.IsWhiteSpace(c: asciiChar))
			// White spaces - set background color to light gray
			e.CellStyle.BackColor = Color.LightGray;
		else if (char.IsDigit(c: asciiChar))
			// Digits - set background color to light green
			e.CellStyle.BackColor = Color.LightGreen;
		else if (char.IsLetter(c: asciiChar))
			// Letters - set background color to light blue
			e.CellStyle.BackColor = Color.LightBlue;
		else
			// Control characters - set background color to light pink
			e.CellStyle.BackColor = Color.LightPink;
	}
	private void txtHex_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Allow backspace
		if (e.KeyChar == '\b') return;

		// Check if the entered character is a valid hexadecimal character
		if (!Regex.IsMatch(input: e.KeyChar.ToString(), pattern: "^[0-9a-fA-F]$"))
		{
			// If not valid, suppress the key press event
			e.Handled = true;
			return;
		}
		RichTextBox textBox = (RichTextBox)sender;

		// Insert a space after every two characters
		if (textBox.Text.Length % 3 != 2) return;
		textBox.Text           += " ";
		textBox.SelectionStart =  textBox.Text.Length;
	}
	private void btnHex2Ascii_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(value: txtHex.Text)) return;
		dgvCharacterList.Rows.Clear();
		string hexInput    = txtHex.Text.Replace(oldValue: " ", newValue: ""); // Remove spaces
		string asciiOutput = HexToAscii(hexInput: hexInput);
		int    index       = 0;
		foreach (char asciiChar in asciiOutput)
		{
			string hexValue                   = Convert.ToString(value: asciiChar, toBase: 16).ToUpper();
			if (hexValue.Length < 2) hexValue = "0" + hexValue; // Add a leading zero if needed
			string charName                   = _controlCharNames.TryGetValue(key: asciiChar, value: out string? controlCharName) ? controlCharName : asciiChar.ToString();
			AddDataGridViewRow(hexValue: hexValue, charName: charName, index: index);
			index++;
		}
		txtAscii.Text      = asciiOutput;
		lblCharacters.Text = $@"Characters Quantity: {asciiOutput.Length}";
	}
	private string HexToAscii(string hexInput)
	{
		StringBuilder sb = new();
		for (int i = 0; i < hexInput.Length; i += 2)
		{
			if (i + 1 >= hexInput.Length) continue;
			string hexPair   = hexInput.Substring(startIndex: i, length: 2);
			byte   byteValue = Convert.ToByte(value: hexPair, fromBase: 16);
			char   asciiChar = Convert.ToChar(value: byteValue);
			sb.Append(value: asciiChar);
		}
		return sb.ToString();
	}
	private void AddDataGridViewRow(string hexValue, string charName, int index)
	{
		DataGridViewRow         row        = new();
		DataGridViewTextBoxCell hexCell    = new();
		DataGridViewTextBoxCell asciiCell  = new();
		DataGridViewTextBoxCell numberCell = new();
		hexCell.Value    = hexValue;
		asciiCell.Value  = charName;
		numberCell.Value = index;
		row.Cells.Add(dataGridViewCell: hexCell);
		row.Cells.Add(dataGridViewCell: asciiCell);
		row.Cells.Add(dataGridViewCell: numberCell);
		dgvCharacterList.Rows.Add(dataGridViewRow: row);
	}
	private void btnAscii2Hex_Click(object sender, EventArgs e)
	{
		if (txtAscii.Text == "") return;
		dgvCharacterList.Rows.Clear();
		string asciiInput = txtAscii.Text;
		string hexOutput  = ConvertAsciiToHexPairs(asciiInput: asciiInput);
		for (int i = 0; i < asciiInput.Length; i++)
		{
			DataGridViewRow         row        = new();
			DataGridViewTextBoxCell hexCell    = new();
			DataGridViewTextBoxCell asciiCell  = new();
			DataGridViewTextBoxCell numberCell = new();
			char                    asciiChar  = asciiInput[index: i];
			string                  hexValue   = Convert.ToString(value: asciiChar, toBase: 16).ToUpper();
			if (hexValue.Length == 1) hexValue = "0" + hexValue;
			int index                          = i + 1;

			// Look up the name in the dictionary if it's a control character
			string charName = _controlCharNames.TryGetValue(key: asciiChar, value: out string? controlCharName) ? controlCharName : asciiChar.ToString();
			AddDataGridViewRow(hexValue: hexValue, charName: charName, index: index);
		}
		lblCharacters.Text = $@"Characters Quantity: {txtAscii.Text.Length}";
		txtHex.Text        = hexOutput;
	}
	private string ConvertAsciiToHexPairs(string asciiInput)
	{
		StringBuilder hexPairs = new();
		foreach (char c in asciiInput)
		{
			string hexValue                    = Convert.ToString(value: c, toBase: 16).ToUpper();
			if (hexValue.Length == 1) hexValue = "0" + hexValue; // Pad with leading zero if needed
			hexPairs.Append(value: hexValue);
			hexPairs.Append(value: " ");
		}
		return hexPairs.ToString().Trim();
	}
	private void frmMain_Load(object sender, EventArgs e)
	{
		timer          =  new();
		timer.Interval =  1000;       // 1 second interval
		timer.Tick     += Timer_Tick; // Attach the event handler
		timer.Start();                // Start the timer
	}
	private void Timer_Tick(object sender, EventArgs e)
	{
		// Update the label with the current date and time including seconds
		lblDateTime.Text = $@"Date and Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
	}
	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		timer.Stop(); // Stop the timer when the form is closing
	}
#endregion
#endregion
}