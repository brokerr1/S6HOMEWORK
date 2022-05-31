/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];
int count = 0;
Console.Write("Введите числа через пробел:");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write("Введите элемент массива: ");
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше нуля:{count}");
