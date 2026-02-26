using System;

Student s1 = new Student("김철수") { KoreanScore = 85, EnglishScore = 90, MathScore = 95 };
Student s2 = new Student("이영희") { KoreanScore = 75, EnglishScore = 80, MathScore = 70 };
Student s3 = new Student("박민수") { KoreanScore = 110, EnglishScore = 120, MathScore = -10 };

s1.PrintInfo();
s2.PrintInfo();
s3.PrintInfo();

class Student
{
    private int _korean_score;
    private int _english_score;
    private int _math_score;
    public string Name { get; }
    public int KoreanScore
    {
        get { return _korean_score; }
        set
        {
            if (value < 0)
            {
                _korean_score = 0;
            }
            else if (value > 100)
            {
                _korean_score = 100;
            }
            else
            {
                 _korean_score = value;
            }
        }
    }
    public int EnglishScore
    {
        get { return _english_score; }
        set
        {
            if (value < 0)
            {
                _english_score = 0;
            }
            else if (value > 100)
            {
                _english_score = 100;
            }
            else
            {
                _english_score = value;
            }
        }
    }
    public int MathScore
    {
        get { return _math_score; }
        set
        {
            if (value < 0)
            {
                _math_score = 0;
            }
            else if (value > 100)
            {
                _math_score = 100;
            }
            else
            {
                _math_score = value;
            }
        }
    }
    public int TotalScore
    {
        get { return KoreanScore + EnglishScore + MathScore; }
    }
    public float Average
    {
        get { return (KoreanScore + EnglishScore + MathScore) / 3.0f; }
    }

    public string Grade
    {
        get
        {
            if (Average >= 90)
                return "A";
            else if (Average >= 80)
                return "B";
            else if (Average >= 70)
                return "C";
            else if (Average >= 60)
                return "D";
            else
                return "F";
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"=== 성적표: {Name} ===");
        Console.WriteLine($"국어: {KoreanScore}, 영어: {EnglishScore}, 수학: {MathScore}");
        Console.WriteLine($"총점: {TotalScore}");
        Console.WriteLine($"평균: {Average:F2}");
        Console.WriteLine($"학점: {Grade}");
    }

    public Student(string name)
    {
        this.Name = name;
    }
}