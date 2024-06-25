using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunSe_It
{
    public class Calculator
    {
        public int sum;//동적변수, 멤버변수
        public static float avg;//정적변수 (멤버변수가아님)
        public int Add(int x,int y)//멤버함수
            { return x + y; }
        public static int divide(int x, int y) //멤버함수가 아니고 정적함수
        {
            return x / y;
        }
    }
}
