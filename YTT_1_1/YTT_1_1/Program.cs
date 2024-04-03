// УП Практическая работа 1.1
// Задание 1. Создайте коллекцию (массив) с 10 случайными числами. Выведите в консоль номер минимального элемента.

namespace YTT_1_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            int min = array[0];
            int index = 0;
            Console.Write($"Массив: ");
            for (int i = 1; i < array.Length; i++)
            {   
                Console.Write($"{array[i]} ");
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Номер минимального элемента массива: {index}");
        }
    }
}