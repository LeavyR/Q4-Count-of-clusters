using System;
using System.Collections;
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
            Dictionary<int, List<clspoint>> myct = new Dictionary<int, List<clspoint>>();
            int i, j;
            int iscontnus = 1;
            for (i = 0; i < str_set.Length; i++)
            {

                int status = 0;
                string[] vStr = StrDeal.sd.strSplit(str_set[i]);
                List<clspoint> clsList = new List<clspoint>();
                for (j = 0; j < vStr.Length; j++)
                {
                    if (vStr[j] == "1")
                    {
                        clspoint cp = new clspoint();
                        cp.h = i;
                        cp.w = j;
                        if (status != 1)
                        {
                            iscontnus++;
                            status = 1;
                        }

                        if (myct.TryGetValue(iscontnus, out clsList))
                        {
                            myct[iscontnus].Add(cp);
                        }
                        else
                        {
                            clsList = new List<clspoint>();
                            clsList.Add(cp);
                            myct.Add(iscontnus, clsList);
                        }

                    }
                    else
                    {
                        status = 0;
                    }
                }
            }
            if (myct.Count <= 1) return myct.Count;

            int count = 0;

            foreach (KeyValuePair<int, List<clspoint>> prekv in myct)
            {
                try
                {
                    foreach (KeyValuePair<int, List<clspoint>> postkv in myct)
                    {
                        if (postkv.Key == prekv.Key) continue;
                        bool isNear = false;
                        foreach (clspoint preCp in prekv.Value)
                        {
                            if (isNear) break;
                            foreach (clspoint postCp in postkv.Value)
                            {
                                if ((preCp.w == postCp.w || Math.Abs(preCp.w - postCp.w) == 1) && Math.Abs(preCp.h - postCp.h) == 1)
                                {
                                    isNear = true;
                                    break;
                                }     

                            }

                        }

                        if (isNear)
                        {
                            myct[prekv.Key].AddRange(myct[postkv.Key]);
                            myct[postkv.Key].Clear();
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
            foreach (KeyValuePair<int, List<clspoint>> countkv in myct)
            {
                if (countkv.Value.Count > 0) count++;
            }

            return count;
        }
        public class clspoint
        {
            public int h = 0;
            public int w = 0;
        }
    }
}
