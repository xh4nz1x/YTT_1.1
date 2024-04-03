// УП Практическая работа 1.1
// Задание 4. Напишите функцию, которая заполняет список случайными числами в диапазоне, указанном пользователем.
// Функция принимает начало диапазона и его конец, и возвращает целочисленный массив.
// С помощью специальной формы цикла for выведете элементы получившегося массив в одну строку, с пробелами.

namespace YTT_1_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] list = new int[10];
            Console.Write("Введите начало диапазона: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            int end = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = random.Next(start, end);
            }
            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]} ");
            }
            
        }
    }
};