using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowVsThrowEx
{
    class Program
    {
        private static void Method1()
        {
            Console.WriteLine("This is Method 1");
            try
            {
                Method2();
            }
            catch (Exception e)
            {
                // log exception e
                // do something....

                throw e;
                // todo: comment the line above and uncomment the line below to see the stack trace difference in the output
                // throw;
            }
        }

        private static void Method2()
        {
            Console.WriteLine("This is Method 2");
            throw new Exception("This exception is thrown from Method2!!!!!");
        }

        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Press ENTER to stop.");
            Console.ReadLine();
        }
    }
}
