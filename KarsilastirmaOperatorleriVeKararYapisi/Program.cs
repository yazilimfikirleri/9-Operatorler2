using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleriVeKararYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 2;
            int s2 = 5;
            bool sart;//true ya da false

            sart = s1 > s2;//true
            //Console.WriteLine(sart);
            //sart = s1 < s2;//false
            //Console.WriteLine(sart);
            //sart = s1 != s2;//true
            //Console.WriteLine(sart);
            //Console.Read();



            if (sart)//karar sonucunu temsil eder. //true
            {
                //eğer karar sonucu true değer gelirse kodlar burdan yorumlanmaya devam eder.
                Console.WriteLine("s1 s2'den büyüktür.");
                Console.Read();
            }
            else//false
            {
                Console.WriteLine("s1 s2'den büyük değildir");
                Console.Read();
            }


        }
    }
}
