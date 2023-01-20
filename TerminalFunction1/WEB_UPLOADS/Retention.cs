using System;
using System.Net;
using CommonBase.Logs;

namespace WEB_UPLOADS
{
    /// <summary>
    /// Variable Definition Class
    /// </summary>
    public class Retention
    {
        /// <summary>
        /// Environment 
        /// </summary>
        public string ENVIRONMENT { get; set; } = null;

        /// <summary>
        /// Execute Current Directory
        /// </summary>
        public string EXECUTE_PATH { get; set; } = null;

        /// <summary>
        /// Execute Current Directory
        /// </summary>
        public string CURRENT_PATH { get; set; } = null;

        /// <summary>
        /// Execute Progran name 
        /// </summary>
        public string PROGRAM_NAME { get; set; } = null;

        /// <summary>
        /// Logger 
        /// </summary>
        public Logger1 LOGGER { get; set; } = null;

        /// <summary>
        /// Server
        /// </summary>
        public string PARAM_SERVER { get; set; } = null;

        /// <summary>
        /// Import File Name String
        /// </summary>
        public string PARAM_FILE_NAME { get; set; } = null;

        /// <summary>
        /// Import Table Name String
        /// </summary>
        public string PARAM_TABLE_NAME { get; set; } = null;

        /// <summary>
        /// Current Path です。
        /// </summary>
        public string GetLoggingLocation()
        {
            return CURRENT_PATH + @"\" + @"Log";
        }

        /// <summary>
        /// Logging Path です。
        /// </summary>
        public string GetCurrentLocation()
        {
            return CURRENT_PATH;
        }

        /// <summary>
        /// Templete Path です。
        /// </summary>
        public string GetTempleteLocation()
        {
            return CURRENT_PATH + @"\" + @"Resources";
        }

        /// <summary>
        /// Output Path です。
        /// </summary>
        public string GetOutputLocation()
        {
            return CURRENT_PATH + @"\" + @"Output";
        }

        /// <summary>
        /// Cookie です。
        /// </summary>
        public static string cookies;
        public static CookieContainer cookeiescontainer;

    }
}
