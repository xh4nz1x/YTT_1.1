// УП Практическая работа 1.1
// Задание 3. Добавляйте новые элементы в список до тех пор, пока пользователь не отправит пустую строку.
// Выведите в консоль самый короткий и самый длинный элементы списка

namespace YTT_1_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int space = 0;
            bool end = false;
            Console.WriteLine("Вводите элементы:");
            while (end == false)
            {
                if (space == 0)
                {
                    Console.WriteLine();
                    space++;
                }
                string element = Console.ReadLine();
                if (element == "" | element == " ")
                {
                    end = true;
                    string max = list[0], min = list[0];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Length < min.Length)
                        {
                            min = list[i];
                        }
                        else if (list[i].Length > max.Length)
                        {
                            max = list[i];
                        }
                    }
                    Console.WriteLine($"Самый короткий элемент списка: {min}");
                    Console.WriteLine($"Самый длинный элемент списка: {max}");

                }
                else
                {
                    list.Add(element);
                }
            }
        }
    }
}