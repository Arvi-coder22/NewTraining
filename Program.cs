using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class GFG
{

    static void pattern(int len)
    {

        for (int i = 0; i < len; i++)
        {
            int j = len - 1 - i;
            for (int k = 0; k < len; k++)
            {

                if (k == i || k == j)
                    Console.Write(k + 1);
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        int len = 5;
        pattern(len);
        Console.ReadKey();
    }
}