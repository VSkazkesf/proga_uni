public class IntegralCalculator
{
    private double f(double x)
    {
        var sinValue = Math.Sin(x);
        var cosValue = Math.Cos(x);
        return cosValue + sinValue;
    }
    
    private double F(double x)
    {
        var sinValue = Math.Sin(x);
        var cosValue = Math.Cos(x);
        return -cosValue + sinValue;
    }

    public double CalculateIntegral(string leftInput, string rightInput, int numOfDivisions)
    {
        var l = leftInput.Split("*Pi/").ToList().ConvertAll(int.Parse).ToList();
        var r = rightInput.Split("*Pi/").ToList().ConvertAll(int.Parse).ToList();
        
        var left = (double)l[0] / l[1] * Math.PI;
        var right = (double)r[0] / r[1] * Math.PI;
        var step = (right - left) / numOfDivisions;

        var partitions = new List<double> { left };
        for (int i = 0; i < numOfDivisions - 1; i++)
        {
            partitions.Add(partitions[i] + step);
        }
        partitions.Add(right);

        double integral = 0;
        for (int i = 0; i < numOfDivisions; i++)
        {
            integral += (f(partitions[i]) + f(partitions[i + 1])) / 2 * step;
        }

        return integral;
    }

    public double CalculateIntegralByNewtonLeibnizFormula(string leftInput, string rightInput)
    {
        var l = leftInput.Split("*Pi/").ToList().ConvertAll(int.Parse).ToList();
        var r = rightInput.Split("*Pi/").ToList().ConvertAll(int.Parse).ToList();
        
        var left = (double)l[0] / l[1] * Math.PI;
        var right = (double)r[0] / r[1] * Math.PI;
        
        double integral;
        integral = F(right) - F(left);
        
        return integral;
    }
}

class Program
{
    static void Main()
    {
        var calculator = new IntegralCalculator();

        Console.WriteLine("Введите левый предел интегрирования в формате: (число)*Pi/(число)");
        string leftInput = Console.ReadLine();

        Console.WriteLine("Введите правый предел интегрирования в формате: (число)*Pi/(число)");
        string rightInput = Console.ReadLine();

        Console.WriteLine("Введите желаемое количество разбиений:");
        int numOfDivisions = int.Parse(Console.ReadLine());

        double result = calculator.CalculateIntegral(leftInput, rightInput, numOfDivisions);
        Console.WriteLine($"Результат интегрирования: {result}");
        
        double resultByNL = calculator.CalculateIntegralByNewtonLeibnizFormula(leftInput, rightInput);
        Console.WriteLine($"Результат интегрирования по формуле Ньютона-Лейбница: {resultByNL}");
    }
}
