using System;

namespace Score_ex
{
    struct Student
    {
        public string name;
        public int Korean;
        public int English;
        public int Math;
        public double average;
    }
     class Program
    {
        static void Main(string[] args)
        {
            Student A;
            Console.Write("이름을 입력하세요");
            A.name = Console.ReadLine();
            Console.Write("국어 점수를 입력하세요");
            A.Korean = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요");
            A.English = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요");
            A.Math = int.Parse(Console.ReadLine());
            A.average = (A.Korean + A.English + A.Math) / 3.0;
            Console.WriteLine("{0}평균 점수는 {1,2:F}입니다", A.name, A.average);
            Console.Read();
        }
    }
}
