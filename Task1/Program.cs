// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
int Degree (int A; int B)
{
    int i = 0;
    int result = A;
    while (i <= B)
    {
        result = result + A;
        i++;
    }
    return result;
}
int res = Degree();
Console.WriteLine("A to the power B is", res);
Console.WriteLine("", Degree());