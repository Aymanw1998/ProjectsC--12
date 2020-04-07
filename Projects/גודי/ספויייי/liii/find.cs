using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liii
{
    class find
    {
        public static int IsFound(liDataSet.kartis_korehDataTable kk, string s)
        {
            int i;
            for (i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["id"].ToString())
                {

                    return i;
                }

            }
            return -1;

        }

        public static bool TowTimes(liDataSet.borrowDataTable kk, string s)
        {

            for (int i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["id"].ToString())
                {
                    return true;

                }
            }
            return false;
        }

        public static bool tow(liDataSet.hazmanotDataTable kk1, string s)
        {
            
            for (int i = 0; i < kk1.Rows.Count; i++)
            {
                if (s == kk1[i]["id"].ToString())
                {
                  
                    
                        return true;
                   

                }
            }
            return false;
        }

        public static int yes(liDataSet.booksDataTable kk, string s)
        {
            for (int i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["name"].ToString())
                {
                    return i;
                }

            }
            return -1;

        }
        public static bool company(liDataSet.spakimDataTable kk, string s)
        {
            int i;
            for (i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["coname"].ToString())
                {

                    return true;
                }

            }
            return false;

        }
        public static bool letterr(string s)
        {
            if (s.Length != 1)
            {
                return false;
            }
            else
            {
                if (!char.IsLetter(s[0]))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }
        public static bool msomn(string s)
        {
            if (s != "yes" && s != "no")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int kayam(liDataSet.booksDataTable kk, string s)
        {
            if (kk == null)
            {
                return -1;
            }
            int i;
            for (i = 0; i < kk.Rows.Count; i++)
            {


                if (s == kk[i]["code"].ToString())
                {

                    return i;
                }

            }
            return -1;

        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }



        public static bool same(liDataSet.borrowDataTable kk, string s, string ss)
        {
            if (kk == null)
            {
                return false;
            }

            for (int i = 0; i < kk.Rows.Count; i++)
            {


                if (s == kk[i]["id"].ToString())
                {
                    if (ss == kk[i]["book name"].ToString())
                    {
                        return true;
                    }

                }

            }
            return false;

        }


        public static int findborrow(liDataSet.borrowDataTable kk, string s)
        {
            for (int i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["id"].ToString())
                    return i;
            }
            return -1;
        }

        public static bool tell(string s)
        {
            int x = s.LastIndexOf("");
            int y = s.IndexOf("");
            if (x == y)
            {
                return true;
            }
            else
                return false;



        }

        //public static Stack<string> Mhsanit (string sss, liDataSet.borrowDataTable kk)
        //{
        ////    Stack<string> s = new Stack<string>();
        ////    for (int i = 0; i < kk.Rows.Count; i++)
        ////    {
        ////        if (sss == kk[i]["date of borowing"].ToString())
        ////        {
        ////            if (kk[i]["id"].ToString()!=null)
        ////               s.Push(kk[i]["id"].ToString());
        ////        }
        ////    }
        ////    if(s!=null )
        ////       return s;
        ////    return null; 
        //}



        public static int mokhan(liDataSet.booksDataTable kk, string s)
        {
            for (int i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["name"].ToString())
                {
                    string ss = kk[i]["amount"].ToString();
                    int l = Convert.ToInt32(kk[i]["amount"]);
                    return l;
                }
            }
            return -1;
        }

        //public static int mispar(Stack<string>a,string s)
        //{
        //    while (a.Count!=0)
        //    {
        //        if 
        //    }
        //}


        public static string hazmanamokhana(liDataSet.hazmanotDataTable kk, string s)
        {

            for (int i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["book name"].ToString() && kk[i]["messagedate"].ToString()=="")
                {
                    string  ss = kk[i]["id"].ToString();
                    return ss; 

                }
                
            }
            return "";
        }

        public static int numsapak(liDataSet.spakimDataTable kk, string s)
        {
            int i;
            for (i = 0; i < kk.Rows.Count; i++)
            {
                if (s == kk[i]["coname"].ToString())
                {

                    return i;
                }

            }
            return -1;

        }

        public static Stack<int>copy(Stack<int>s )
        {
            Stack<int> sm = new Stack<int>();
           
            while(s.Count!=0)
            {
                sm.Push(s.Pop());
            }
            return sm;
        }

       


















        }
    }


