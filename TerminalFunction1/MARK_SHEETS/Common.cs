using System;

namespace MARK_SHEETS
{
    public class Common
    {
        public static int GetNendo()
        {
            DateTime now = DateTime.Now;
            int num = int.Parse(now.ToString("yyyy"));
            int num2 = int.Parse(now.ToString("MM"));
            if (num2 <= 3)
            {
                num--;
            }
            return num;
        }

    }
}
