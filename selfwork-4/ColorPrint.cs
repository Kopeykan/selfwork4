using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Selfwork_4
{
    public class print
    {
         public static void ColorPrint(object obj)
        {
           
            Type t = obj.GetType();
            ConsoleColor defaultColor = Console.ForegroundColor;
            foreach (PropertyInfo p in t.GetProperties())
            {
                object[] objects = p.GetCustomAttributes(false);
                foreach (object o in objects)
                {
                    if (o is ColorAttribute)
                    {
                        Console.ForegroundColor = (o as ColorAttribute).Color;
                        continue;
                    }
                }
                Console.WriteLine(p.GetValue(obj));
                Console.ForegroundColor = defaultColor;
               
            }
        }
    }
}