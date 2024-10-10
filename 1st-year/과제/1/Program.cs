using System;

class test
{
    static void Main()
    {
        const int total_subjects = 3;

        int cheol_korean = 89;
        int cheol_math = 80;
        int cheol_english = 92;
        int cheol_average = (cheol_korean + cheol_math + cheol_english) / total_subjects;

        int young_korean = 90;
        int young_math = 88;
        int young_english = 90;
        int young_average = (young_korean + young_math + young_english) / total_subjects;

        Console.WriteLine("철수의 점수는\n국어 : {0}\n수학 : {1}\n영어 : {2}\n평균 : {3}", cheol_korean, cheol_math, cheol_english, cheol_average);
        Console.WriteLine("영희의 점수는\n국어 : {0}\n수학 : {1}\n영어 : {2}\n평균 : {3}", young_korean, young_math, young_english, young_average);
    }
}