namespace HomeworkWithDelegateAndException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions =
            {
                new ArgumentException("Не верный аргумент"),
                new Exception("Что то сломалось"),
                new EnterException("Не верный ввод"),
                new ArgumentNullException ("Входной аргумет"),
                new ArgumentOutOfRangeException ("Входной аргумент")
            };
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception ex2)
                {
                    ConsoleColor defCol = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n=========================");
                    Console.WriteLine("Вы вызвали ошибку");
                    Console.WriteLine(ex2.Message);
                    Console.WriteLine("=========================\n");
                    Console.ForegroundColor = defCol;
                }
                finally
                {
                    Console.WriteLine( "Finally, do something");
                }
                Console.ReadLine();
            }
        }
    }
}
