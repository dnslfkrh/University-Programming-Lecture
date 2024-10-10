using System;

class VariableDemo
{
    static void Main()
    {
        int i;
        i = 1234;
        Console.WriteLine(i);

        int number = 7; // 변수 선언과 동시에 초기화 (값에 7을 저장 후 시작)
        Console.WriteLine("{0}", number); // 자리표시자 (사용 문자열 순서대로 숫자 칸으로 이동)

        int number1, number2, number3;
        number1 = 1;
        number2 = 2;
        number3 = 3;
        Console.WriteLine("{0}, {1}, {2}", number1, number2, number3); // 자리표시자 사용

        int a, b, c;
        a = b = c = 10;
        Console.WriteLine("{0}, {1}, {2}", a, b, c); // 자리표시자 사용

        const int MAX = 100; // 상수 선언
        Console.WriteLine("최댓값 : {0}", MAX);

        int min = -214783648;
        int max = +214783647;
        Console.WriteLine("int 변수의 최솟값 : {0}", min);
        Console.WriteLine("int 변수의 최댓값 : {0}", max);

        //decimal d = 0m;
        //d = decimal.TryParse("12.34", out d);
    }
}