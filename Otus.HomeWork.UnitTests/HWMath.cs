namespace Otus.HomeWork.UnitTests
{
    public class HWMath
    {
        public double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a < Double.Epsilon)
                throw new Exception("Коэффициент a равен 0");

            double[] result = new double[0];

            double D = Math.Pow(b, 2.0) - (4.0 * a * c);

            result = D < (-1 * Double.Epsilon) ?
                result
                : D < Double.Epsilon ?
                    new double[] { -b / (2.0 * a) }
                    : new double[] { (-b + Math.Sqrt(D)) / (2.0 * a), (-b - Math.Sqrt(D)) / (2.0 * a) };

            return result;
        }
    }
}