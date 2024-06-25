using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YunSe_It;

namespace _0625수업
{
    internal class MainApp
    {
        //static void Recursive(int num)
        //{
        //    if(num<=0)return;
        //    Console.WriteLine($"재귀 함수 호출{num}");
        //    Recursive(num-1);

        //}
        //static int factorial(int n)
        //{
        //    if (n == 0)
        //        return 1;
        //    else 
        //        return n *factorial(n-1) ;
        //}
        //public static void Main(string[] args)
        //{
        //    #region 정적변수 동적변수의 차이
        //    //Calculator.avg = 0f;
        //    ////클래스명.정적변수명 
        //    //Calculator cal =    new Calculator();//동적할당
        //    //cal.sum = 0;//멤버변수
        //    //Console.WriteLine(cal.Add(1,2));
        //    //Calculator cal2=new Calculator();
        //    //cal2.sum = 0;
        //    //Console.WriteLine(cal2.Add(10, 20));
        //    //Calculator cal3 = new Calculator();
        //    //cal3.sum = 0;
        //    //Console.WriteLine(cal3.Add(100,200));
        //    //Console.WriteLine(Calculator.divide(30,3));
        //    #endregion


        //    Recursive(3);
        //    Console.WriteLine($"1! = {factorial(1)}");
        //    Console.WriteLine($"2! = {factorial(2)}");
        //    Console.WriteLine($"3! = {factorial(3)}");
        //    Console.WriteLine($"4! = {factorial(4)}");
        //}
        static int Mypower(int num, int cnt)
        {
            if (cnt == 0)
            {
                return 1;
            }
            return num * Mypower(num, --cnt);

        }
        static void Main()
        {
            Console.Write("2의 몇승을 입력할까요? : ");
            int y = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Mypower(2, y));
        }










    }
}
