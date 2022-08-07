// Условия итоговой задачи за 1 четверть читай в файле README.md
Console.Clear();
string[] UserArray()
{
    Console.Write("Введите количество элементов строкового массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    string[] userarray = new string [count];
    Console.Write($"Введите {count} элементов текста (через Enter): ");
    for (int i = 0; i < userarray.Length; i++)
    {
        if (Console.ReadLine() is not null)
        {
            userarray[i] = Console.ReadLine();
        }
    }
    return userarray;
}
string[] uarray = UserArray();

