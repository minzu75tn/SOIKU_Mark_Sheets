using System;
using System.ComponentModel;

namespace MARK_SHEETS
{
    /// <summary>
    /// Enum Definition Class
    /// </summary>

    public static class EnumDefine
    {
        /// <summary>
        /// enum Kyouka type
        /// </summary>
        public enum KYOUKA_TYPE : byte
        {
            [Description("国語")]
            Kokugo = 10,
            [Description("社会")]
            Syakai = 40,
            [Description("数学")]
            Suugaku = 20,
            [Description("理科")]
            Rika = 50,
            [Description("英語")]
            Eigo = 30
        }

        /// <summary>
        /// enum Sentaku type
        /// </summary>
        public enum SENTAKU_TYPE : byte
        {
            [Description("")]
            None = 0,
            [Description("Ａ")]
            A = 1,
            [Description("Ｂ")]
            B = 2
        }

        /// <summary>
        /// enum get description (string)
        /// </summary>
        public static string GetDescription(this Enum Value)
        {
            var field = Value.GetType().GetField(Value.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute != null)
            {
                return attribute.Description;
            }
            else
            {
                return Value.ToString();
            }
        }

        /// <summary>
        /// enum Get enum element values as an array (string)
        /// </summary>
        public static string[] GetValueArrayCodeName()
        {
            var elements = Enum.GetValues(typeof(KYOUKA_TYPE)).Length;
            string[] retValues = new string[elements];
            int aa = -1;

            foreach (KYOUKA_TYPE elmValue in Enum.GetValues(typeof(KYOUKA_TYPE)))
            {
                string elmName = Enum.GetName(typeof(KYOUKA_TYPE), elmValue);
                aa++;
                retValues[aa] = elmName;
            }

            StringComparer cmp = StringComparer.OrdinalIgnoreCase;
            Array.Sort(retValues, cmp);

            return retValues;
        }

    }
}
