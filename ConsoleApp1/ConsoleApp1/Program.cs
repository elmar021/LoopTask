
#region task1
// Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.
//using System;
//class HelloWorld
//{
//    static void Main()
//    {
//        int m = 41;
//        int i;
//        int a = 0;
//        if (m == 1 || m < 0)
//        {
//            Console.WriteLine("BASQA EDED DAXIL EDIN");

//        }

//        else
//        {

//            for (i = 1; i <= m; i++)
//            {
//                if (m % i == 0)
//                {
//                    a++;
//                }
//            }
//            if (a == 2)
//            {
//                Console.WriteLine(m + " ededi sadedir");
//            }
//            else
//            {
//                Console.WriteLine(m + " ededi murekkebdir");
//            }
//        }

//    }
//}
#endregion task1



#region task 2
//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
using System;
class HelloWorld
{
    static void Main()
    {
        int m = 234646;
        int count = 0;
        int k;
        while (m > 0)
        {

            count++;
            m /= 10;

        }
        Console.WriteLine( count + " mertebelidir");
    }
}
#endregion