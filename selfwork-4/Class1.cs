using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Selfwork_4
{
    public class class1
    {
        [Color(Color = ConsoleColor.Magenta)]
        public string SomeProperty { get; set; }
        [Color(Color = ConsoleColor.Yellow)]
        public string AnotherPoperty { get; set; }
        public class1()
        {
            SomeProperty = "SomeProperty in class1";
            AnotherPoperty = "AnotherProperty in class1";
        
        }
    }
}