using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clusterCount
{
    public class StrDeal
    {
        public static StrDeal sd = new StrDeal();
        /// <summary>
        /// 字符串分解为Hashtable
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string[] strSplit(string str)
        {
           

            string[] arrStr = str.Split(new char[] { ' ' });

            return arrStr;
        }
    }
}
