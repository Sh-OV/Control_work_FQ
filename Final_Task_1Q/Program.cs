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

string[] SelectArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] selectarray = new string [count];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            selectarray[k] = array[i];
            k++;
        }
    }
    return selectarray;
}
string[] sarray = SelectArray(uarray);
