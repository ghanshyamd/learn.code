using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd.delegates
{
    public delegate void Action<in T>(T obj);
    public delegate int testInt<T>(T obj);
    public delegate string testString<T>(T obj);

    public delegate int FuncTwoInts(int one, int two);

    public class testCls
    {
        public delegate int AddMethod(int i, int j);

        public int add(int i, int j)
        {
            return i + j;
        }

        public int add10(int i, int j)
        {
            return i + j + 10;
        }

        private static void PrintWith_2and4(FuncTwoInts func)
        {
            int result = func(2, 4);
            Console.WriteLine(result);
        }


        private static string result;

        static void Main()
        {
          
        }


        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }


        delegate void Printer();

        public static void Main(String[] args)
        {
            SaySomething();
            Console.WriteLine(result);
           

            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }

            testCls cls = new testCls();

            PrintWith_2and4((x, y) => x * y);
            PrintWith_2and4((x, y) => x + y);
            PrintWith_2and4((x, y) => 999);


            AddMethod addM = new AddMethod(cls.add);
            addM += cls.add10;

            Console.WriteLine("Press any key");

            Console.ReadLine();
        }
    }

    



}
