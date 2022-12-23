using System;
public class perfectnumbers
{
    public static void Main()
    {
        int n, i, sum;
        int n1, n2;


        Console.Write("enter the first number : ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the second number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        for (n = n1; n <= n2; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }
}