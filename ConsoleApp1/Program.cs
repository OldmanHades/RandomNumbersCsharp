namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1,100);
            int num2 = random.Next(1, 100);
            int num3 = random.Next(1, 100);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);




            Console.ReadKey();
        }
    }
}

