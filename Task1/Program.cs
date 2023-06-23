// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
int Degree(int A, int B)
{
    int i = 1;
    int result = 1;
    while (i <= B)
    {
        result = result * A;
        i++;
    }
    return result;
}
Console.WriteLine("Input namber A: ");
int nam = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input natural number B: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
if (nam1 <= 0)
{
    Console.WriteLine("Error! Try again");
}
else
{
    int res = Degree(nam, nam1);
    Console.WriteLine("The number A to the power of B is");
    Console.WriteLine(res);
}
