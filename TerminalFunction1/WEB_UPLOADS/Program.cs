using System;
using System.Configuration;
using System.Diagnostics;

using CommonBase;
using CommonBase.Alerts;
using CommonBase.Logs;
using CommonBase.Tables;

namespace WEB_UPLOADS
{
	static class Program
    {
		static Mutex objMutex = null;
		static Retention RETENTION = new Retention();
		static Logger1 LOGGER = new Logger1();
        public static FM00000 FM00000X;

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
                Messages1.ShowMessage("MS00100", null);
				goto finalize9;
			}

/*
            string[] Commands = Environment.GetCommandLineArgs();
			if (Commands.Length != 4)
			{
                string[] embedArray = new string[1] { "起動パラメータが不正です。" };
                Messages1.ShowMessage("MS80050", embedArray);
                goto finalize9;
            }
            RETENTION.PARAM_SERVER = Commands[1];
            RETENTION.PARAM_FILE_NAME = Commands[2];
            RETENTION.PARAM_TABLE_NAME = Commands[3];
*/

            RETENTION.EXECUTE_PATH = Application.ExecutablePath;
			RETENTION.CURRENT_PATH = Environment.CurrentDirectory;
			RETENTION.PROGRAM_NAME = Path.GetFileName(RETENTION.EXECUTE_PATH);

			LOGGER.PUT_TRACE_INITIALIZE(RETENTION.GetLoggingLocation());

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
