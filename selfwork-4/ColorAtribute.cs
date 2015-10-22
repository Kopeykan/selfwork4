using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Selfwork_4
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColorAttribute : System.Attribute
    {
        public ConsoleColor Color { get; set; }

        public ColorAttribute()
        {
            Color = Console.ForegroundColor;
        }
        public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }

        
       
    }
}