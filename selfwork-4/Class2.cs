using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Selfwork_4
{
    public class class2
    {
        public string SomeProperty { get; set; }
        [Color(Color = ConsoleColor.DarkBlue)]
        public string AnotherPoperty { get; set; }
        public class2()
        {
            
            SomeProperty = "SomeProperty in class2";
            AnotherPoperty = "AnotherProperty in class2";

        }
    }
}