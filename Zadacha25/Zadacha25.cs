/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
System.Console.WriteLine("Enter A: ");
double A=double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter B: ");
int B=int.Parse(Console.ReadLine());
double AtodegreeB (double A, int B)
{
    if (B<=0)
    {
        System.Console.WriteLine("B must be natural, try again");
        return 0;
    }
    else {
        double AinB=A;
        for (int index=1; index<B; index++)
        {
            AinB=AinB*A;
        }
        return AinB;
    }
}
System.Console.WriteLine(AtodegreeB (A,B));