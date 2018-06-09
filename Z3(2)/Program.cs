using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Z3_2_
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;

    }

    class Program
    {

        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            Console.WriteLine("----- Class ----");
            c.change = "not changed";
            Console.WriteLine(c.change);
            ClassTaker(c);
            Console.WriteLine(c.change);

            MyStruct s = new MyStruct();
            Console.WriteLine("----- Struct ----");
            s.change = "not changed";
            Console.WriteLine(s.change);
            StructTaker(s);
            Console.WriteLine(s.change);


            Console.ReadLine();
        }
    }
}
