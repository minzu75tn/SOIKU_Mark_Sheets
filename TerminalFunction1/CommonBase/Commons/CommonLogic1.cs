using System;
using System.IO;

namespace CommonBase.Commons
{
    /// <summary>
    /// Online Common Utility Class
    /// </summary>
    public class CommonLogic1
    {
        private const string CHAR_SINGLE_QUOTE = "'";
        private const string ENCODE_SINGLE_QUOTE = "&#39;";

        /// <summary>
        /// 現在日時を取得
        /// </summary>
		/// <returns>YYYYMMDDHHMMSS</returns>
        public DateTime CurrentTime
        {
            get
            {
                var now = DateTime.Now;
                return new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            }
        }

        /// <summary>
        /// フォルダの存在チェックを実施、存在しない時に作成
        /// </summary>
		/// <param name="location">directory path</param>
		/// <returns>DirectoryInfo</returns>
        public static DirectoryInfo SafeCreateDirectory(string location)
        {
            if (Directory.Exists(location))
            {
                return null;
            }
            return Directory.CreateDirectory(location);
        }

        /// <summary>
        /// ファイルの存在チェックを実施
        /// </summary>
		/// <param name="location">directory file path</param>
		/// <returns>bool</returns>
        public static bool ExistsFile(string location)
        {
            return File.Exists(location);
        }

        /// <summary>
        /// 文字列が数値であるかどうかを返します。
        /// </summary>
        /// <param name="Target">検査対象となる文字列<param>
        /// <returns>指定した文字列が数値であれば true。それ以外は false。</returns>
        public static bool IsNumeric(string Target)
        {
            double dNullable;
            return double.TryParse(
                Target,
                System.Globalization.NumberStyles.Any,
                null,
                out dNullable
            );
        }

        /// <summary>
        /// 文字列の指定した位置から指定した長さを取得する
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="start">開始位置</param>
        /// <param name="len">長さ</param>
        /// <returns>取得した文字列</returns>
        public static string Mid(string str, int start, int len)
        {
            if (start <= 0)
            {
                throw new ArgumentException("引数'start'は1以上でなければなりません。");
            }
            if (len < 0)
            {
                throw new ArgumentException("引数'len'は0以上でなければなりません。");
            }
            if (str == null || str.Length < start)
            {
                return "";
            }
            if (str.Length < (start + len))
            {
                return str.Substring(start - 1);
            }
            return str.Substring(start - 1, len);
        }

        /// <summary>
        /// 文字列の指定した位置から末尾までを取得する
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="start">開始位置</param>
        /// <returns>取得した文字列</returns>
        public static string Mid(string str, int start)
        {
            return Mid(str, start, str.Length);
        }

        /// <summary>
        /// 文字列の先頭から指定した長さの文字列を取得する
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="len">長さ</param>
        /// <returns>取得した文字列</returns>
        public static string Left(string str, int len)
        {
            if (len < 0)
            {
                throw new ArgumentException("引数'len'は0以上でなければなりません。");
            }
            if (str == null)
            {
                return "";
            }
            if (str.Length <= len)
            {
                return str;
            }
            return str.Substring(0, len);
        }

        /// <summary>
        /// 文字列の末尾から指定した長さの文字列を取得する
        /// </summary>
        /// <param name="str">文字列</param>
        /// <param name="len">長さ</param>
        /// <returns>取得した文字列</returns>
        public static string Right(string str, int len)
        {
            if (len < 0)
            {
                throw new ArgumentException("引数'len'は0以上でなければなりません。");
            }
            if (str == null)
            {
                return "";
            }
            if (str.Length <= len)
            {
                return str;
            }
            return str.Substring(str.Length - len, len);
        }

        /// <summary>
        ///  SQLコマンド行の指定された項目を置き換える（ありのまま設定）
        ///  </summary>
        /// <param name="Statements"></param>
        /// <param name="Target"></param>
        /// <param name="Values"></param>
        /// <returns>Change After Statements</returns>
        /// <remarks></remarks>
        public static string ReplaceStatement(string Statements, string Target, string Values)
        {
            return Statements.Replace(Target, Values);
        }

        /// <summary>
        ///  SQLコマンド行の指定された項目を置き換える（文字列版）
        ///  </summary>
        /// <param name="Statements"></param>
        /// <param name="Target"></param>
        /// <param name="Values"></param>
        /// <returns>Change After Statements</returns>
        /// <remarks></remarks>
        public static string ReplaceStatementString(string Statements, string Target, string Values)
        {
            return Statements.Replace(Target, EncircleSingleQuote(Values));
        }

        /// <summary>
        ///  SQLコマンド行の指定された項目を置き換える（数値版）
        ///  </summary>
        /// <param name="Statements"></param>
        /// <param name="Target"></param>
        /// <param name="Values"></param>
        /// <returns>Change After Statements</returns>
        /// <remarks></remarks>
        public static string ReplaceStatementNumeric(string Statements, string Target, int Values)
        {
            return Statements.Replace(Target, Convert.ToString(Values));
        }

        /// <summary>
        ///  文字列を「'」で囲む（エンコード指定可能）
        ///  </summary>
        /// <param name="target"></param>
        /// <param name="use_encode"></param>
        /// <returns>Change After Statements</returns>
        /// <remarks></remarks>
        public static string EncircleSingleQuote(object target, bool use_encode = false)
        {
            if (use_encode)
            {
                return ENCODE_SINGLE_QUOTE + target + ENCODE_SINGLE_QUOTE;
            }
            else
            {
                return CHAR_SINGLE_QUOTE + target + CHAR_SINGLE_QUOTE;
            }
        }

    }
}
