using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CommonBase.XMLparser
{
    public class XMLparser1
    {
        /// <summary>
        /// XMLファイルから値を取得（すべて）
        /// </summary>
        /// <param name="filepath">XMLファイル名</param>
        /// <param name="elements">エレメント名</param>
        /// <returns>XElement</returns>
        public static IEnumerable<XElement> GetXmlElements(string filepath, string elements)
        {
            IEnumerable<XElement> elms = null;
            try
            {
                XElement xml = XElement.Load(filepath);
                elms = from item in xml.Elements(elements) select item;
            }
            catch (Exception ex)
            {
                throw;
            }
            return elms;
        }

        /// <summary>
        /// XMLファイルから値を取得（条件指定：一致するもの）
        /// </summary>
        /// <param name="filepath">XMLファイル名</param>
        /// <param name="elements">エレメント名</param>
        /// <param name="items">指定項目</param>
        /// <param name="criterias">検索条件</param>
        /// <returns>XElement</returns>
        public static IEnumerable<XElement> GetXmlArray(string filepath, string elements, string items, string criterias)
        {
            IEnumerable<XElement> elms = null;
            try
            {
                XElement xml = XElement.Load(filepath);
                elms = from item in xml.Elements(elements)
                       where item.Element(items).Value == criterias
                       select item;
            }
            catch (Exception ex)
            {
                throw;
            }
            return elms;
        }

    }
}
