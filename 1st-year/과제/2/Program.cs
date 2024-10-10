using System;

class test2
{
    static void Main()
    {
        Console.WriteLine("성적 입력 프로그램입니다.");
        Console.WriteLine("이름을 입력하세요.");

        Console.Write("이름: ");
        string 이름 = Console.ReadLine();

        Console.Write("학번: ");
        string 학번 = Console.ReadLine();

        Console.Write("국어 점수: ");
        int 국어점수 = int.Parse(Console.ReadLine());

        Console.Write("수학 점수: ");
        int 수학점수 = int.Parse(Console.ReadLine());

        Console.Write("영어 점수: ");
        int 영어점수 = int.Parse(Console.ReadLine());

        int 총점 = 국어점수 + 수학점수 + 영어점수;
        double 평균 = 총점 / 3.0;

        Console.WriteLine("\n성적 조회");
        Console.WriteLine($"이름 : {이름}");
        Console.WriteLine($"학번 : {학번}");
        Console.WriteLine($"국어 : {국어점수} - {function(국어점수)}");
        Console.WriteLine($"수학 : {수학점수} - {function(수학점수)}");
        Console.WriteLine($"영어 : {영어점수} - {function(영어점수)}");
        Console.WriteLine($"총점 : {총점}");
        Console.WriteLine($"평균 : {평균:F1} - {function((int)평균)}");

        if (평균 >= 70.0 ? true : false)
            Console.WriteLine($"{이름}님은 장학금 대상자입니다.");
        else
            Console.WriteLine($"{이름}님은 장학금 대상자가 아닙니다.");
    }
    static string function(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}