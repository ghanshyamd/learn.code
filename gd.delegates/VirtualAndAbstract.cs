using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndAbstract
{
    public abstract class VirtualAndAbstract
    {
        public virtual void testMethod(String s)
        {
            Console.WriteLine($"TEST {s}");
        }

        public static void testStatic(String s)
        {
            Console.WriteLine($"TEST NEW {s}");
        }
    }


    public class MainClass : VirtualAndAbstract
    {
        public override void testMethod(string s)
        {
            base.testMethod(s);

            testStatic("TEST");

            Console.WriteLine($"TEST OVRRIDE {s}");
        }

        public void InstanceMethod()
        {
            base.testMethod("TEST");
        }
    }
}


///////
///
namespace StaticExample
{
    public static class StaticClass
    {
        public static void TestMethod(String s)
        {
            Console.WriteLine($"TEST {s}");
        }

    }


    public sealed class SealedClass
    {
        public static void staticMethod(String s)
        {
            Console.WriteLine($"TEST STATIC {s}");
        }

        public void nonStaticMethod(String s)
        {
            Console.WriteLine($"TEST NON STATIC {s}");
        }
    }

    public class NormalClass
    {
        public static void staticMethod1(String s)
        {
            Console.WriteLine($"TEST STATIC {s}");
        }

        public virtual void nonStaticMethod1(String s)
        {
            Console.WriteLine($"TEST NON STATIC {s}");
        }
    }

    public class MainClass : NormalClass
    {
        public static void Main(String[] args)
        {
            SealedClass t = new SealedClass();
            t.nonStaticMethod("TEST");
            staticMethod1("TeE");

        }

        public new virtual void nonStaticMethod1(String s)   //////METHOD HIDING SHADOWING
        {

        }

        public void MainMethod()
        {
            base.nonStaticMethod1("Test");

        }

    }

    public class ShadowingOverride :MainClass
    {

        public override void nonStaticMethod1(String a)
        {

        }
    }

}
