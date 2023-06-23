// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum(int gmt)
{
    int res=0;
    while (gmt > 0)
    {
        res = res + gmt % 10;
        gmt = gmt / 10;
    }
    return res;
}
Console.WriteLine("Input namber: ");
int namber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(namber));
