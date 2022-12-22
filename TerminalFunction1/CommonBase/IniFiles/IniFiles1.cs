using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CommonBase.IniFiles
{
    /// <summary>
    /// INI File Definition Class
    /// </summary>
    public class IniFiles1
    {
        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName);

        [DllImport("KERNEL32.DLL")]
        private static extern uint GetPrivateProfileSection(
            string lpAppName,
            string lpKeyName,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        /// <summary>
        /// INIファイルから値を取得
        /// </summary>
        /// <param name="lnSection">セッション名称</param>
        /// <param name="lnKeyName">キー名称</param>
        /// <param name="lnFileName">INIファイル名</param>
        /// <returns></returns>
        public static string GetIniString(string inSection, string inKeyName, string inFileName, string inFilePath)
        {
            StringBuilder strValue = new StringBuilder(1024);
            uint sLen = GetPrivateProfileString(inSection, inKeyName, "", strValue, 1024, inFilePath + "\\" + inFileName);
            return strValue.ToString();
        }

    }
}
