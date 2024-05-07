using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  task1

            //int x = 10;
            //int y = 4;
            //int c = x + y;
            //int f = x - y;
            //int h = x * y;
            //Console.WriteLine(c);
            //Console.WriteLine(f);
            //Console.WriteLine(h);
            #endregion
            #region task3
            //int x;
            //x = int.Parse(Console.ReadLine());

            //if (x > 1 && x < 6) ;

            //{
            //    Console.WriteLine("usaq");                //alinmadi..........
            //}

            //else if (x > 5 && x < 18) ;
            //{
            //    Console.WriteLine(" sagird");
            //}

            //else if (x > 17 && x < 36) ;
            //{
            //    Console.WriteLine("genc");
            //}


            //else if (x > 35 && x < 64) ;
            //{
            //    Console.WriteLine("yetkin");
            //}

            //else if (x > 63) ;
            //{
            //    Console.WriteLine("teqaudcu");
            //}


            #endregion
            #region task2
            //int y = int.Parse(Console.ReadLine());
            //if (y > 86400) ;
            //int gun = y / 86400;
            //y = y - (gun * 86400);
            //int saat = y / 3600;
            //y = y - (saat *3600);
            //int dk = y / 60;
            //int san = y - (dk * 60);
            //Console.WriteLine(gun);
            //Console.WriteLine(saat);
            //Console.WriteLine(dk);
            //Console.WriteLine(san);
            #endregion
            #region task4
            //char x = char.Parse(Console.ReadLine());
            //switch (x)
            //{ 
            //    case '1':
            //        Console.WriteLine("bazar ertesi");
            //        break;
            //    case '2':
            //        Console.WriteLine("cersenbe axsami");
            //        break;
            //    case '3':
            //        Console.WriteLine("cersenbe");
            //        break;
            //    case '4':
            //        Console.WriteLine("cume axsami");
            //        break;
            //    case '5':
            //        Console.WriteLine("cume");
            //        break;
            //    case '6':
            //        Console.WriteLine("senbe");
            //        break;
            //    case '7':
            //        Console.WriteLine("bazar");
            //        break;
            //}
            #endregion

            char x = char.Parse(Console.ReadLine());
            switch (x)
            {

                case '1':
                    Console.WriteLine("yanvar,31");
                    break;
                case '2':
                    Console.WriteLine("fevral,28");
                    break;
                case '3':
                    Console.WriteLine("mart,31");
                    break;
                case '4':
                    Console.WriteLine("aprel,30");
                    break;
                case '5':
                    Console.WriteLine("may,31");
                    break;
                case '6':
                    Console.WriteLine("iyun,30");
                    break;
                case '7':
                    Console.WriteLine("iyul,31");
                    break;
                case '8':
                    Console.WriteLine("avqust,31");
                    break;
                case '9':
                    Console.WriteLine("sentyabr,30");
                    break;
                    if (x =='10') ;
                    {
                        Console.WriteLine("oktyabr,10");
                    }
               
                

            }



        }
    }
}