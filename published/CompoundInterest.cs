using System;

class CompoundInterest
{
    static void Main()
    {
        double p, r, t, amount, ci;

        Console.Write("Enter Principal: ");
        p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        t = Convert.ToDouble(Console.ReadLine());

        amount = p * Math.Pow((1 + r / 100), t);
        ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);
    }
}
