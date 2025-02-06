using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using Animes;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiDimension Array

            int[,] b = new int[4, 4];
            b[0, 0] = 23;
            b[0, 1] = 100;
            b[1, 1] = 22;
            b[2, 2] = 99;
            b[3, 3] = 45;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=====================");
            //Jagged Array

            int[][] data = new int[4][]; //declare
            data[0] = new int[] { 57, 35, 76, 22 };
            data[1] = new int[] { 95, 22, 77, 33, 88, 76544 };
            data[2] = new int[] { 11, 22, 44 };
            data[3] = new int[] { 85, 11 };

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {

                    Console.Write(data[i][j] + ",");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

//Movie m = new Movie();
//m.GetMovie();
//Anime a = new Anime();
//a.GetAnime();
//Console.Read();

//1st task
//for(int i=1; i<=10; i++)
//{
//    Console.WriteLine(i);
//}

//2nd task
//Console.WriteLine("Enter 1st no. : ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 2nd no. : ");
//int b = Convert.ToInt32(Console.ReadLine());

//int c = a + b;
//Console.WriteLine("Sum : " + c);

//3d task
//Console.WriteLine("Enter no. : ");
//int a = Convert.ToInt32(Console.ReadLine());

//if(a%2==0)
//{
//    Console.WriteLine("It is Divisible");
//}
//else
//{
//    Console.WriteLine("Not-Divisible");
//}

//4th task
//Console.WriteLine("Enter no. : ");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}

//5th task
//int a = 10;
//int b = 5;
//int temp;

//Console.WriteLine("Old A : "+a);
//Console.WriteLine("Old B :"+b);

//Console.WriteLine("After Swaping");

//temp = a;
//a = b;
//b = temp;

//Console.WriteLine("New A :"+a);
//Console.WriteLine("New B :"+b);

//6th task

//Console.WriteLine("Enter 1st no. : ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 2nd no. : ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter 3rd no. : ");
//int c = Convert.ToInt32(Console.ReadLine());

//if (a > b && a > c)
//{
//    Console.WriteLine("A is Greater");
//}
//if(b > a && b > c)
//{
//    Console.WriteLine("B is Greater");
//}
//if(c > a && c > b)
//{
//    Console.WriteLine("C is Greater");
//}

//7th task
//Console.WriteLine("Enter no. : ");
//int a = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i<=10; i++)
//{
//    int c = a * i;

//    Console.WriteLine(a + " x " + i + " = " + c);
//}


//Console.WriteLine("Please Enter a name :");

//string data = Console.ReadLine();
//Console.WriteLine("You entered : " + data);
//Console.WriteLine("Please Enter 1st Value :");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please Enter 2st Value :");
//int b = Convert.ToInt32(Console.ReadLine());

//string result = (a == b) ? "Equal" : "Not Equal";
//Console.WriteLine(result);
//while(a < 10)
//{
//    a++;
//    Console.WriteLine(a);
//}
//do
//{
//    a++;
//Console.WriteLine($"Print : {a}");
//Console.WriteLine("Print : {0}", a);
//    Console.WriteLine("Print :" + a);
//}
//while (a<10);
//for(int i=0; i<=a; i++)
//{
//    Console.WriteLine(i);
//}

//if(a==b)
//{
//   Console.WriteLine("Equal");
//}
//else if(a > b)
//{
//  Console.WriteLine("A is Greater");
//}
//else if(a < b)
//{
//   Console.WriteLine("B is Greater");
//}
//else
//{
//  Console.WriteLine("Invalid");
//}
//Movie movie = new Movie();
//movie.GetMovie();
