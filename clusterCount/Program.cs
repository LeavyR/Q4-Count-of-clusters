using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clusterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


               // Console.Write("please input the w h\n");
                string wh = Console.ReadLine();
                string[] whStr = StrDeal.sd.strSplit(wh);
                int w = 0;
                int h = 0;
                if (whStr.Length != 2)
                {
                    Console.Write("please input the w h\n");
                    continue;
                }
                try
                {
                    w = Int32.Parse(whStr[0]);
                    h = Int32.Parse(whStr[1]);
                }
                catch
                {
                    Console.Write("please input the correct int  w h\n");
                    continue;
                }
                if (w == 0 && h == 0) break;
                string[] str_set = new string[h];
                string tmp=string.Empty;
                while(h>0)
                {
                    str_set[h-1] = Console.ReadLine();                    
                    h--;
                }

                Console.Write(clsCount.cls.count(str_set,h,w)+"\n");

            }

        }
    }
}
