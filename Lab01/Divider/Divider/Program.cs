using System;

namespace Divider
{
    class Divider
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine("i/j = {0}", k);
            }
            catch(FormatException e)
            {
                Console.WriteLine("A format exception was thrown: {0}", e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("A DivideByZero was thrown: {0}", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception was throw {0}", e.Message);
            }


        }
    }
}
