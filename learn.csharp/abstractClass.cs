using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class abstractClass
    {
        public abstractClass(string s)
        {
            Console.WriteLine($"abstract class {s}");
        }

        private int add(int i, int j)
        {
            return i + j;
        }

        public int sum(int i, int j)
        {
            Console.WriteLine($"TEST {i + j}");
            return i * j;
        }
    }


    public class MainClass : abstractClass
    {

        public MainClass(string s) : base(s)
        {
            Console.WriteLine($"Main class {s}");
        }

        public static void Main(String[] args)
        {
            MainClass _this = new MainClass("child");
            _this.getAbstract();
            Console.ReadLine();
        }

        private void getAbstract()
        {
            base.sum(2, 4);
        }

    }
}
