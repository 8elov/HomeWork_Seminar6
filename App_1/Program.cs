// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Какое количество чисел вы хотите ввести? ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];

int GetPositive(int M)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите " + (i + 1) + " число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    int sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive ++;
        }
    }
    return sumPositive;
}

Console.WriteLine("Количество чисел больше 0 = " + GetPositive(M)); 
