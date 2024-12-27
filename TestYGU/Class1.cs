using System;


public class Task
{
        public static double Abs(double x)
    {
        if (x < 0) return x * -1;
        return x;
    }

    public static double Sqrt(double number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Корень из отрицательного числа не определен.");
        }
        
        if (number == 0 || number == 1)
        {
            return number;
        }

        double tolerance = 1e-10; 
        double guess = number / 2.0; 
        
        while (Abs(guess * guess - number) > tolerance)
        {
            guess = (guess + number / guess) / 2.0; 
        }

        return guess;
    }

    public static double TaylorSin(double x, int terms = 10)
    {
        double result = 0.0;
        double term = x; 
        for (int n = 0; n < terms; n++)
        {
            result += term;
            term *= -x * x / ((2 * n + 2) * (2 * n + 3)); 
        }
        return result;
    }

    public static double TaylorCos(double x, int terms = 10)
    {
        double result = 0.0;
        double term = 1.0; 
        for (int n = 0; n < terms; n++)
        {
            result += term;
            term *= -x * x / ((2 * n + 1) * (2 * n + 2)); 
        }
        return result;
    }

    public static double TaylorLn(double x, int terms = 10)
    {
        if (x <= 0) throw new ArgumentOutOfRangeException(nameof(x), "Логарифм из числа меньше 0 не определен");
        double result = 0.0;
        double term = (x - 1) / x;
        for (int n = 1; n <= terms; n++)
        {
            result += term / n;
            term *= (x - 1) / x; 
        }
        return result;
    }

    public static double MyFunction(double x)
    {
        if (x <= 0)
        {
            return Sqrt(TaylorSin(x) * TaylorCos(TaylorLn(Abs(x))));
        }
        else
        {
            return (1 - TaylorCos(x)) / TaylorSin(x);
        }
    }
}
