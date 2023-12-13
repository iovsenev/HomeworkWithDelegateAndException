using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWithDelegateAndException
{
    public static class FamalyList
    {
        static List<string> _list;
        public static void Run(List<string> list)
        {
            _list = list;
            SorterList sl = new SorterList();
            sl.SortListEvent += SelectSortingDirrection;
            while (true)
            {
                try
                {
                    sl.Sort(_list);
                    break;
                }
                catch (FormatException ex)
                {
                    ConsoleColor def = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n====================");
                    Console.WriteLine("Не верный ввод! введите либо 1 либо 2!");
                    Console.WriteLine("====================\n");
                    Console.ForegroundColor = def;
                }
            }
        }
        static void SelectSortingDirrection(int num)
        {
            switch (num)
            {
                case 1: _list.Sort(); break;
                case 2: _list.Sort(); _list.Reverse(); break;
            }
        }
    }
}
