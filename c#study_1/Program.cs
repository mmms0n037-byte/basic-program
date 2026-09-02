namespace c_study_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 이름은 무엇입니까?");
            string name = Console.ReadLine();

            Console.WriteLine("당신의 나이는 몇 살입니까?");
            string age = Console.ReadLine();

            Console.WriteLine("당신의 국어 성적은 몇입니까?");
            string A = Console.ReadLine();

            Console.WriteLine("당신의 수학 성적은 몇입니까?");
            string B = Console.ReadLine();

            Console.WriteLine("당신의 영어 성적은 몇입니까?");
            string C = Console.ReadLine();

            Console.WriteLine("당신의 이름은 " + name + "이며, 나이는 " + age + "살 이며, 국어는 " + A + "점, 수학은 " + B + "점, 영어는 " + C + "점 입니다.");
        }
    }
}
