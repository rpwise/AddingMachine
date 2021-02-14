using System;

namespace Utilities
{
    public static class Calcultions 
    {
        public static int AddTwoNumbers(int var1, int var2)
        {
            // initialize return variable
            var total = 0;

            try
            {
                total = var1 + var2;
            }
            catch (Exception ex)
            {
                Console.Write("Error: " + ex.Message);
            }

            // return result
            return total;
        }

        // override for strings
        public static int AddTwoNumbers(string var1, string var2)
        {
            if (var1 == null)
            {
                throw new ArgumentNullException("var1");
            }
            if (var2 == null)
            {
                throw new ArgumentNullException("var2");
            }

            // initialize return variable
            var total = 0;

            try
            {
                // parse strings to int
                var var1Num = Int32.Parse(var1);
                var var2Num = Int32.Parse(var2);

                // once converted, leverage method above
                total = AddTwoNumbers(var1Num, var2Num);
            }
            catch (Exception ex)
            {
                Console.Write("Error: " + ex.Message);
            }

            // return result
            return total;
        }
    }
}