using System;
internal partial class program
{
    private static void main(string[] args)
    {
        int num, i, x, y, z;
        Console.Write("pleas enter number1:");
        int y = int.Parse(Console.ReadLine());
        y = y

Console.Write("pleas enter number2:");
        z = y

    for (num = y; num <= z; num++) ;
        {
            x = 0;
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    x++;
                    break;
                }
            }
            if (x == 0 && num != 1)
                Console.Write("{0}", num);


        }
        {
        }

