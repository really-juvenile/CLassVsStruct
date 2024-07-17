using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLassVsStruct.Models;

class MyClass
{
    public int X { get; set; }
    public int Y { get; set; }

    public MyClass(int x, int y)
    {
        X = x;
        Y = y;
    }
}

struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }

    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        //class (reference type)
        MyClass obj1 = new MyClass(1, 2);
       MyClass obj2 = new MyClass(1, 2);

          Console.WriteLine("Class obj1 HashCode: " + obj1.GetHashCode());
        Console.WriteLine("{Class obj2 HashCode: " + obj2.GetHashCode());

        Console.WriteLine("here we can see that obj1 and Obj2 hashcodes are different because they are reference types ");

       //struct (value type)

        MyStruct struct1 = new MyStruct(1, 2);
        MyStruct struct2 = new MyStruct(1, 2);

        Console.WriteLine("Struct struct1 HashCode: " + struct1.GetHashCode());
         Console.WriteLine("Struct struct2 HashCode: " + struct2.GetHashCode());

        Console.WriteLine("here both hashcodes are same so struct is value type");
        //ALso a major difference between both are that classes support inheritance
        // struct majorly doesnt suppport inheritance
    }
}
