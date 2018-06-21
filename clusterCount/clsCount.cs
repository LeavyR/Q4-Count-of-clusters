using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clusterCount
{
    public class clsCount
    {
        public static clsCount cls = new clsCount();

        public int count(string[] str_set, int w, int h)
        {
            char[][] array = new char[h][];
            int i, j;
            for (i = 0; i < str_set.Length; i++)
            {
                string[] vStr = StrDeal.sd.strSplit(str_set[i]);
                for (j = 0; j < vStr.Length; j++)
                {
                    array[i][j] = vStr[j][0];
                }
            }
            int count = 0;
            for (i = 0; i < h; i++)
            {
               
            }
            return count;
        }
    }
}
