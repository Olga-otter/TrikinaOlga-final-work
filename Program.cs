﻿Console.Clear();
void FindInArray(string[] array)
{
    int count = 0;
    int limit = 3;
    for (int a = 0; a < array.Length; a++)
    {
        if (array[a].Length <= limit) count++;
    }
    string[] arrayNew = new string[count];
    int b = 0;
    for (int c = 0; c < array.Length; c++)
    {
        if(array[c].Length <= limit) 
        {
            arrayNew[b] = array[c];
            b++;
        }
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", arrayNew)}]");
}

Console.WriteLine("Введите кол-во элементов массива : ");
int lengthMassive = Convert.ToInt32(Console.ReadLine());
string[] Masonry = new string[lengthMassive];
for (int i = 0; i < lengthMassive; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива : ");
    Masonry[i] = Console.ReadLine();   
}
Console.WriteLine($"Начальный масссив: [{string.Join(", ", Masonry)}]");
FindInArray(Masonry);

