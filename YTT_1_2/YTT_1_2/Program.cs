// УП Практическая работа 1.1
// Задание 2. Добавляйте новые числа в список до тех пор, пока пользователь не введет 0.
// Выведите в консоль сумму и произведение всех элементов списка.
// Выведите средннее, среди всех элементов списка.

namespace YTT_1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int avarage = 0, product = 1, sum = 0, space = 0;
            bool end = false;
            Console.WriteLine("Вводите числа:");
            while (end == false)
            {
                if (space == 0)
                {
                    Console.WriteLine();
                    space++;
                }
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    end = true;
                    for (int i = 0; i < list.Count; i++)
                    {
                        sum += list[i];
                        product *= list[i];
                    }

                    avarage = sum / list.Count;
                    Console.WriteLine($"Сумма всех элементов списка: {sum}");
                    Console.WriteLine($"Произведение всех элементов списка: {product}");
                    Console.WriteLine($"Среднее арифметическое всех элементов списка: {avarage}");
                }
                else
                {
                    list.Add(num);
                }
            }
        }
    }
}