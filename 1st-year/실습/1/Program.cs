using System;

class test
{
    static void Main()
    {
        Console.WriteLine("성적 입력 프로그램입니다.");

        while (true)
        {
            string name;
            int numSubjects;
            float[] subjectScores;

            do
            {
                Console.Write("이름을 입력하세요.\n이름 : ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
                }

            } while (string.IsNullOrWhiteSpace(name));

            try
            {
                Console.Write("과목 수를 입력하세요.\n");
                string numSubjectsInput = Console.ReadLine();

                if (!int.TryParse(numSubjectsInput, out numSubjects) || numSubjects < 1)
                {
                    throw new Exception("잘못된 입력입니다. 처음으로 돌아갑니다.");
                }

                subjectScores = new float[numSubjects];

                for (int i = 0; i < numSubjects; i++)
                {
                    Console.Write($"{i + 1}번째 과목 점수 : ");
                    string scoreInput = Console.ReadLine();

                    if (!float.TryParse(scoreInput, out subjectScores[i]))
                    {
                        throw new Exception("잘못된 입력입니다. 처음으로 돌아갑니다.");
                    }
                }

                Console.WriteLine($"{name}님의 성적을 알려드립니다.");

                for (int i = 0; i < numSubjects; i++)
                {
                    Console.WriteLine($"{i + 1}번째 과목 점수 : {subjectScores[i]}점");
                }

                float totalScore = calculateTotalScore(subjectScores);
                float averageScore = calculateAverage(subjectScores);

                Console.WriteLine($"{name}님의 총점은 {totalScore}점 입니다.");
                Console.WriteLine($"{name}님의 평균은 {averageScore:F2}점 입니다.");

                char grade = calculateGrade(averageScore);
                Console.WriteLine($"{name}님의 학점은 {grade} 입니다.");


                Console.Write("처음부터 입력하시겠습니까? (Y/N)");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                {
                    Console.WriteLine("종료합니다.");
                    return;
                }
                else
                {
                    Console.WriteLine("처음으로 돌아갑니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    static float[] grades = { 90f, 80f, 70f, 60f };

    static float calculateTotalScore(float[] scores)
    {
        float total = 0;
        foreach (float score in scores)
        {
            total += score;
        }
        return total;
    }

    static float calculateAverage(float[] scores)
    {
        if (scores.Length == 0)
            return 0;
        return calculateTotalScore(scores) / scores.Length;
    }

    static char calculateGrade(float average)
    {
        if (average >= grades[0])
            return 'A';
        else if (average >= grades[1])
            return 'B';
        else if (average >= grades[2])
            return 'C';
        else if (average >= grades[3])
            return 'D';
        else
            return 'F';
    }
}
