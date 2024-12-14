using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_14_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(456);
            //list.Add(123);
            //list.Add(18);

            //list[0] = 134;

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int n = 78;
            //object obj = n; // boxing

            //int t = (int)obj; // unboxing

            //===================== Dictionary =====================

            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //dict.Add("one", 1);
            //dict.Add("two", 2);
            //dict.Add("three", 3);

            //if (!dict.ContainsKey("one"))
            //{
            //    dict.Add("one", 2);
            //}

            //foreach (string item in dict.Keys)
            //{
            //    Console.WriteLine($"{item}: {dict[item]}");
            //}

            //foreach (int item in dict.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, List<string>> dictL = new Dictionary<int, List<string>>();
            //dictL.Add(34, new List<string>());
            //dictL[34].Add("Hello");
            //dictL[34].Add("Yes");

            //dictL.Add(12, new List<string>());
            //dictL[12].Add("qwer");
            //dictL[12].Add("rewq");
            //dictL[12].AddRange(new string[] { "122","159","789"});

            //dictL.Add(23, new List<string>());
            //dictL[23].Add("sssss");
            //dictL[23].Add("sdff");

            //foreach (int key in dictL.Keys)
            //{
            //    Console.WriteLine($" key: {key}");
            //    foreach (string item in dictL[key])
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //}

            //Dictionary<int, string> dict2 = new Dictionary<int, string>
            //{
            //    [7] = "qwew",
            //    [8] = "re",
            //    [9] = "sd",
            //    [10] = "gf"
            //};

            // ===================== ===================

            Point<int> point = new Point<int>(45,65);
            Console.WriteLine(point.x);

            Point<double> point2 = new Point<double>(/*23.32, 65.78*/);
            Console.WriteLine(point2.y);

            //Point<string> point3 = new Point<string>(/*23.32, 65.78*/);
            //Console.WriteLine(point2.y);

            //Example<MyClass> ex = new Example<MyClass>();
            MyGenericClass<Class1, MyClass> myg = new MyGenericClass<Class1, MyClass>();

            Console.ReadKey();
            Console.ReadKey();
        }
    }

    internal class Class1
    {
    }

    class MyClass : IComparable<MyClass>
    {
        DateTime date
            ;
        public MyClass()
        {

        }
        public MyClass(int n)
        {

        }
        public int CompareTo(MyClass obj)
        {
            return date.CompareTo(obj.date);
        }

        //public int CompareTo(object obj)
        //{
        //    if (obj is MyClass my)
        //    {
        //        return this.date.CompareTo(my.date);
        //    }
        //    throw new ArgumentException();
        //}
    }
    //class Example<D> where D : class, IComparable, new()
    //{

    //}
    class MyGenericClass<D,T> where D : new() where T : class, IComparable<T>, new()
    {

    }
    class Point<T> where T : struct
    {
        public T x { get; set; }
        public T y { get; set; }
        public Point()
        {
            x = default;
            y = default;
        }
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
