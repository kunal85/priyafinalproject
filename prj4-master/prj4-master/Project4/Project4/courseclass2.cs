﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class courseclass2
    {
        private static string stname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        private static string t2;
        public static string gets1()
        {
            return stname;
        }

        public static void sets1(String stuname)
        {
            string s;
            s = stname;
            stname = stuname;
            if (s != stname)
            {
                System.Windows.Forms.MessageBox.Show("The valus has changed to" + stname);
            }
        }

        public static int getnocours()
        {
            return courseno;

        }

        public static void setsnocours(int course)
        {
            int c;
            c = courseno;
            courseno = course;
            if (c != courseno)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to" + courseno);
            }
        }

        public static DateTime getdate()
        {
            return dateTime;

        }

        public static void setdate(DateTime dtTime)
        {
            DateTime d;
            d = dateTime;
            dateTime = dtTime;
            if (d != dateTime)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to" + dateTime);
            }
        }

        public static string gettype()
        {
            return type2;

        }

        public static void settype(string Type)
        {
            string t3;
            t3 = type2;
            type2 = Type;
            if ( t3 != type2)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to " + type2);
            }
            
        }

        public static string getno()
        {
            return type2;

        }

        public static void setno(string Type)
        {
            string t4;
            t4 = t2;
            t2 = Type;
            if ( t4 != t2)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to " + t2);
            }
            
        }
    }
}

