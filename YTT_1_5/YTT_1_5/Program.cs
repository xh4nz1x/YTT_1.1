// УП Практическая работа 1.1
// Задание 5. В строке, которую вводит пользователь, определите количество слов, добавьте в начало строки слово Start и в конец строки слово End

namespace YTT_1._1_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            string[] words = line.Split(' ');
            Console.WriteLine($"Количество слов в строке: {words.Length}");
            line = line.Insert(0, "Start ");
            line = line.Insert(line.Length, " End");
            Console.WriteLine($"Измененная строка: {line}");

        }
    }
}