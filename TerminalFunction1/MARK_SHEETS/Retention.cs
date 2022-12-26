using System;
using System.Configuration;
using CommonBase.Logs;

namespace MARK_SHEETS
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
        /// DB Connection String
        /// </summary>
        public string DB_DATA_SOURCE { get; set; } = null;
        public ConnectionStringSettings DB_CONNECTION_STRING { get; set; } = new ConnectionStringSettings();

        /// <summary>
        /// Worker Prosessで利用する変数など 
        /// </summary>
        public string GOU_ID { get; set; } = null;
        public string KYOUKA_ID { get; set; } = null;
        public string SENTAKU_ID { get; set; } = null;
        public string NENDO { get; set; } = null;
        public string GROUP_ID { get; set; } = null;
        public string KAIJYOU_ID { get; set; } = null;

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

    }
}
