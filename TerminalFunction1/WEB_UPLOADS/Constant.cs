using System;

namespace WEB_UPLOADS
{
    /// <summary>
    /// Constant Definition Class
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// Steis DataBase   
        /// </summary>
        public static string STEIS { get; } = "Steis";
        public static string STEIS1 { get; } = "Steis1";
        public static string STEIS2 { get; } = "Steis2";
        public static string STEIS3 { get; } = "Steis3";

        /// <summary>
        /// Marks_Design Folder   
        /// </summary>
        public static string MARKS_DESIGN_FOLDER { get; } = @"\Marks_Design\Design";
        /// <summary>
        /// Marks Folder   
        /// </summary>
        public static string MARKS_PRODUCT_FOLDER { get; } = @"\Marks";

        /// <summary>
        /// マーク位置情報データ   
        /// </summary>
        public static string MARKS_LOCATE_FILE { get; } = @"Locate";

        /// <summary>
        /// 模範解答データ   
        /// </summary>
        public static string MARKS_ANSWER_FILE { get; } = @"Answer";

        /// <summary>
        /// File Extention Name   
        /// </summary>
        public static string FILE_EXTENTION_CSV { get; } = @".csv";
    }
}
