using System;
public class leapyear
{
    public static void Main(string[] args)
    {
        int checkyear;
        

        Console.WriteLine("Enter the Year");

        checkyear = Convert.ToInt32(Console.ReadLine());

        if ((checkyear % 400) == 0)
            Console.WriteLine("{0} is a leap year.\n", checkyear);
        else if ((checkyear % 100) == 0)
            Console.WriteLine("{0} is not a leap year.\n", checkyear);
        else if ((checkyear % 4) == 0)
            Console.WriteLine("{0} is a leap year.\n", checkyear);
        else
            Console.WriteLine("{0} is not a leap year.\n", checkyear);
    }
}