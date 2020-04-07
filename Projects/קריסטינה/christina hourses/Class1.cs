using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christina_hourses
{
    class Class1
    {

        public static bool Maail(string l)
        {
            int c = 0;
            int n = 0;
            char k = l[n];
            bool bl = true;

            while (n != l.Length&& bl==true)
            {
                n = n + 1;

                if (k != '@')
                {
                    c = c + 1;
                    k = l[n];
                }
               else
                    bl = false;

            }
                int i = l.Length;
           
                if (l[i-1] == 'l' && l[i - 2] == 'i' && l[i - 3] == '.' && l[i - 4] == 'o' && l[i - 5] == 'c' && l[i - 6] == '.')
                    return true;

                 i = l.Length;

                if (l[i-1] == 'm' && l[i - 2] == 'o' && l[i - 3] == 'c' && l[i - 4] == '.')
                    return true;

                return false;
            
        }
    }

}
