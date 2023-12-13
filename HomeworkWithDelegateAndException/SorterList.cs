using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWithDelegateAndException
{
    public class SorterList
    {
        public delegate void SortListDelegate(int num);
        public event SortListDelegate SortListEvent;

        public void Sort(List<string> list)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите как бы вы хотели отсортировать список.");
            Console.WriteLine("Если по возрастанию - 1; Если по убыванию - 2;");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ваш выбор: ");
            Console.ForegroundColor = def;
            var enter = Convert.ToInt32(Console.ReadLine());
            if (enter != 1 && enter != 2)
                throw new FormatException();
            SortLists(enter);
        }

        protected virtual void SortLists(int num)
        {
            SortListEvent?.Invoke(num);
        }
    }
}
