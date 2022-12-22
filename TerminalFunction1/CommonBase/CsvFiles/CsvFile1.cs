using System;
using System.Collections;
using System.Text;

using Microsoft.VisualBasic.FileIO;

namespace CommonBase.CsvFiles
{
    public class CsvFile1
    {
        /// <summary>
        ///  csvファイルをハッシュにセット
        ///  </summary>
        /// <param name="file"></param>
        /// <param name="columnCheck"></param>
        /// <returns>ArrayList</returns>
        /// <remarks></remarks>
        public static ArrayList Csv2Hash(string file, bool columnCheck, ref string results)
        {
            ArrayList arrayList = new ArrayList();
            checked
            {
                using (TextFieldParser textFieldParser = new TextFieldParser(file, Encoding.GetEncoding("shift_jis")))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(",");
                    string[] array = textFieldParser.ReadFields();
                    int num = 1;
                    while (!textFieldParser.EndOfData)
                    {
                        string[] array2 = textFieldParser.ReadFields();
                        Hashtable hashtable = new Hashtable();
                        int columns = array2.Length - 1;
                        for (int ii = 0; ii <= columns; ii++)
                        {
                            if (columnCheck)
                            {
                                if (array2[ii] == null)
                                {
                                    results = Convert.ToString(num) + "行目不正:" + array[ii] + "未設定";
                                    return null;
                                }
                                if (array2[ii].Length == 0)
                                {
                                    results = Convert.ToString(num) + "行目不正:" + array[ii] + "未設定";
                                    return null;
                                }
                            }
                            hashtable[array[ii]] = array2[ii];
                        }
                        arrayList.Add(hashtable);
                        num++;
                    }
                    return arrayList;
                }
            }
        }

    }
}
