using System;

namespace CommonBase
{
    /// <summary>
    /// Constant Definition Class
    /// </summary>
    public class ConstantCommon
    {
        /// <summary>
        /// App.Config KEY
        /// </summary>
        public const string CONFIG_SERVER_DRIVE = "ServerDrive";
        public const string CONFIG_LOG_PATH = "LogPath";
        public const string CONFIG_LOG_LEVEL = "LogLevel";
        public const string CONFIG_EXCLUDE_TEST = "ExcludeTest";

        /// <summary>
        /// Log Message Level
        /// </summary>
        public enum LOGLEVEL : byte
        {
            Debug = 1,
            Trace = 2,
            Information = 3,
            Warning = 4,
            Error = 5
        }

    }
}
