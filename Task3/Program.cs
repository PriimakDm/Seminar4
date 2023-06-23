// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] Arrey (int size_arrey)
{
    int [] arrey1 = new int [size_arrey];
    for (int i = 0; i < size_arrey; i++)
    {
        arrey1[i] = new Random().Next(0, 99);
    }
    return arrey1;
}

void PrintArrey (int [] arrey_print)
{
    Console.WriteLine("Arrey: ");
    for (int i = 0; i < arrey_print.Length; i++)
        Console.Write (arrey_print[i] + " ");
}

Console.WriteLine("Input size of arrey: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arrey2 = Arrey(size);
PrintArrey (arrey2);