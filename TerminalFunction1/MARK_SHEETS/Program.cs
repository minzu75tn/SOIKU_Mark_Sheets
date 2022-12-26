using System;
using System.Configuration;
using System.Diagnostics;

using CommonBase;
using CommonBase.Alerts;
using CommonBase.Logs;
using CommonBase.Tables;

namespace MARK_SHEETS
{
	static class Program
    {
		static Mutex objMutex = null;
		static Retention RETENTION = new Retention();
		static Logger1 LOGGER = new Logger1();
		static FM00000 FM00000X;

		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Message.Json Define
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            DirectoryInfo info = Directory.GetParent(appPath);
            string messagePath = Path.Combine(info.FullName, "Resources");
            messagePath = Path.Combine(messagePath, "message.json");
            Messages1.Load(messagePath);

            // Multiple Startup
            string strOwnName = Process.GetCurrentProcess().ProcessName;
			objMutex = new System.Threading.Mutex(false, strOwnName);
			if (objMutex.WaitOne(0, false) == false)
			{
                Messages1.ShowMessage("MS00100");
				goto finalize9;
			}

            string[] Commands = Environment.GetCommandLineArgs();
            RETENTION.DB_DATA_SOURCE = Commands.Length == 1 ? Constant.STEIS1 : Constant.STEIS + Commands[1];
            RETENTION.DB_CONNECTION_STRING = ConfigurationManager.ConnectionStrings[RETENTION.DB_DATA_SOURCE];

            RETENTION.EXECUTE_PATH = Application.ExecutablePath;
			RETENTION.CURRENT_PATH = Environment.CurrentDirectory;
			RETENTION.PROGRAM_NAME = Path.GetFileName(RETENTION.EXECUTE_PATH);

			LOGGER.PUT_TRACE_INITIALIZE(RETENTION.GetLoggingLocation());
			LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, RETENTION.PROGRAM_NAME + " Main Started.");
			if (Tables1.DB_Connection(RETENTION.DB_CONNECTION_STRING.ConnectionString) == null)
			{
				goto finalize9;
			}

			FM00000X = new FM00000();
			try
			{
				RETENTION.LOGGER = LOGGER;
				Global.RETENTION = RETENTION;
				Application.Run(FM00000X);
			}
			catch (Exception ex)
			{
                string[] embedArray = new string[1] { ex.ToString() };
                Messages1.ShowMessage("MS90010", embedArray);
				goto finalize9;
			}

			Tables1.DB_DisConnection();
			LOGGER.PUT_TRACE_MESSAGE(ConstantCommon.LOGLEVEL.Information, RETENTION.PROGRAM_NAME + " Main Ended.");
			LOGGER.PUT_TRACE_FINALIZE();

		finalize9:
			objMutex.Close();
		}
	}
}
