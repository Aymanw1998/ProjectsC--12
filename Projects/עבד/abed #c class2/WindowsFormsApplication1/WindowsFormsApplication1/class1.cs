using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class class1
    {
        public static int mispar(abedDataSet.dhmDataTable t)
        {
            int count = 0;
            for (int i = 0; i < t.Rows.Count; i++)
            {
                count = i;
            }
            return count;
        }


        public static string Skhom(abedDataSet.hazmnt_lakDataTable t, int x)
        {

            double i;
            string st="";
            double sum = 0;
            if (t != null)
            {
                for (int y = 0; y < t.Rows.Count; y++)
                {
                    string str = Convert.ToString(x);
                    if (str == t.Rows[y]["mispar hishbonit"].ToString())
                    {
                        i = Convert.ToDouble(str);
                        sum = sum + i;
                    }
                    st = Convert.ToString(sum);
                }


               
            }
            return st;

        }
     

    }


}

