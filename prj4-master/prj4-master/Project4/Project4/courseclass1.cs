using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    
        public static class courseclass1
        {
            private static string stdname;
            private static int nocourse;
            private static DateTime dateTime;
            private static string type1;
        private static string t;



            public static void gets1()
            {
                courseclass2.sets1(stdname);

            }

            public static void sets1(String sname)
            {
                stdname = sname;
                gets1();
            }

            public static void getnocours()
            {
                courseclass2.setsnocours(nocourse);

            }

            public static void setsnocours(int course)
            {
                nocourse = course;
                getnocours();
            }

            public static void getdate()
            {
                courseclass2.setdate(dateTime);

            }

            public static void setdate(DateTime dtTime)
            {
                dateTime = dtTime;
                getdate();
            }

            public static void gettype()
            {
                courseclass2.settype(type1);

            }

            public static void settype(string Type)
            {
                type1 = Type;
                gettype();
            }

        public static void getnumber()
        {
            courseclass2.settype(t);

        }

        public static void setnumber(string T)
        {
            t = T;
            getnumber();
        }
    }
    }

