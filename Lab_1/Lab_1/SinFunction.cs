using System;

class SinFunction
{
    private double a;
    private double b;

    public void SetParameters(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double Compute(double x)
    {
        return Math.Sin(a * x + b);
    }

    public bool IsMaxAtX(double x)
    {
        double derivative = a * Math.Cos(a * x + b);

        if (derivative > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}