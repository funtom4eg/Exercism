using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Squares
{
    public int CountNaturals { get; set; }

    public Squares(int count)
    {
        if (count < 0)
            throw new ArgumentOutOfRangeException();
        CountNaturals = count;
    }

    public double SquareOfSums()
    {
        double result = 0;
        for(int i = 1; i<=CountNaturals;i++)
        {
            result += i;
        }
        return Math.Pow(result, 2);
    }

    public double SumOfSquares()
    {
        double result = 0;
        for (int i = 1; i <= CountNaturals; i++)
            result += Math.Pow(i, 2);
        return result;
    }

    public double DifferenceOfSquares()
    {
        return Math.Abs(SumOfSquares() - SquareOfSums());
    }
}
