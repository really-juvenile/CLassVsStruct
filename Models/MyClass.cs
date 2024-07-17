using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassVsStruct.Models
{
    internal class MyClass
    {
            public int X { get; set; } //autoprop
            public int Y { get; set; }

            public MyClass(int x, int y)
            {
                X = x;
                Y = y;
            }

        struct MyStruct
        {
            public int X { get; set; } //autoprop
            public int Y { get; set; }

            public MyStruct(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

    }
}

