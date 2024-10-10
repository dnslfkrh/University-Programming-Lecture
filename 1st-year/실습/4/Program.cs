using System;

class Program
{
    static float[] gradeThresholds = { 90f, 80f, 70f, 60f };

    static void Main()
    {
        Console.WriteLine("성적 입력 프로그입니다.");
        do
        {
            string name = GetStudentName();
            int subjectCount = GetSubjectCount();

            if (subjectCount == -1) continue;

            float[] scores = GetSubjectScores(subjectCount);

            if (scores == null) continue;

            DisplaySubjectScores(name, scores);
            DisplayTotalAndAverage(name, scores);

            char continueChoice = GetContinueChoice();

            if (continueChoice != 'Y' && continueChoice != 'y') break;

        } while (true);

        Console.WriteLine("종료합니다.");
    }

    static string GetStudentName()
    {
        string name;
        do
        {
            Console.WriteLine("이름을 입력하세요.");
            Console.Write("이름: ");
            name = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
            }

        } while (string.IsNullOrEmpty(name));

        return name;
    }

    static int GetSubjectCount()
    {
        int subjectCount;
        do
        {
            Console.Write("과목 수를 입력하세요: ");
            if (!int.TryParse(Console.ReadLine(), out subjectCount) || subjectCount <= 0)
            {
                Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
                return -1;
            }

            break;

        } while (true);

        return subjectCount;
    }

    static float[] GetSubjectScores(int subjectCount)
    {
        float[] scores = new float[subjectCount];

        for (int i = 0; i < subjectCount; i++)
        {
            do
            {
                Console.Write($"{i + 1} 번째 과목 점수 : ");
                if (!float.TryParse(Console.ReadLine(), out scores[i]) || scores[i] < 0 || scores[i] > 100)
                {
                    Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
                    return null;
                }

                break;

            } while (true);
        }

        return scores;
    }

    static void DisplaySubjectScores(string name, float[] scores)
    {
        Console.WriteLine($"{name}님의 성적을 알려드립니다.");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"{i + 1} 번째 과목 점수 : {scores[i]}점");
        }
    }

    static void DisplayTotalAndAverage(string name, float[] scores)
    {
        float total = 0;
        foreach (float score in scores) total += score;

        float average = total / scores.Length;

        Console.WriteLine($"{name}님의 총점은 {total}점 입니다.");
        Console.WriteLine($"{name}님의 평균은 {average:F2}점 입니다.");

        DisplayGrade(name, average);
    }

    static void DisplayGrade(string name, float average)
    {
        char grade = 'F';

        for (int i = 0; i < gradeThresholds.Length; i++)
        {
            if (average >= gradeThresholds[i])
            {
                grade = (char)('A' + i);
                break;
            }
        }

        Console.WriteLine($"{name}님의 학점은 {grade} 입니다.");
    }

    static char GetContinueChoice()
    {
        char choice;
        do
        {
            Console.Write("계속하시겠습니까? (Y/N): ");
            if (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
                continue;
            }

            choice = char.ToUpper(choice);

            if (choice != 'Y' && choice != 'N')
            {
                Console.WriteLine("잘못된 입력입니다. 처음으로 돌아갑니다.");
                continue;
            }

            break;

        } while (true);

        return choice;
    }
}
