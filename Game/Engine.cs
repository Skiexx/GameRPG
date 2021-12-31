using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Engine
    {
        public static int Select()
        {
            int Id;
            while (true)
            {
                Console.Write("Выберите персонажа:\n1. Лучник\n2. Воин\n3. Священник\nID - ");
                try
                {
                    Id = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception x)
                {
                    Console.WriteLine($"Ошибка! + {x.Message}");
                    Console.WriteLine("Нажмите <Enter> чтобы продолжить.");
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.Enter)
                {
                    keyInfo = Console.ReadKey();
                }
                Console.Clear();
            }
            return Id;
        }
    }
}
