namespace HexDevide;

internal static class Program
{
#region Mthods
#region Other
	/// <summary>
	///     The main entry point for the application.
	/// </summary>
	[STAThread]
	private static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();
		Application.Run(mainForm: new frmMain());
	}
#endregion
#endregion
}