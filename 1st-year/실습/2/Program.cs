using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            //2023년 9월 18일 작성
            int a = 123;
            int b = 321;
            string s = "123";
            s = s + a;
            Console.WriteLine(s);
            Console.Write("줄 바꿈 없음\n"); // \n = 줄 바꾸기
            Console.WriteLine("줄 바꿈 포함");
            Console.WriteLine("a는{0}이고, b는{1}이다., \n두 수의 합은{2}이다.", a, b, a + b); // 자리 표시자
        }
    }
}
