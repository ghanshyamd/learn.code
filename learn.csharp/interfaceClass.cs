using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterface
{
    public interface ICompare
    {
        int add(int i, int j);
        int sum(int i, int j);
    }


    public class MainClass : ICompare
    {
        public static void Main(String[] args)
        {
            MainClass _this = new MainClass();
            _this.add(4,5);
            _this.sum(2,5);
            Console.ReadLine();
        }

        public int add(int i, int j)
        {
            return i + j;
        }

        public int sum(int i, int j)
        {
            return i + j;
        }
    }
}
