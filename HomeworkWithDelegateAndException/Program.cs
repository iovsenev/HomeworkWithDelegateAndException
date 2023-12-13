namespace HomeworkWithDelegateAndException
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExceptionTask.Run();
            Console.WriteLine();
            List<string> lastNames = new List<string>
            {
                "Попов",
                "Александров",
                "Сидоров",
                "Иванов",
                "Васечкин"
            };
            FamalyList.Run(lastNames);
            Console.WriteLine();

            foreach (string name in lastNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
