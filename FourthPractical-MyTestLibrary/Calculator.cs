namespace FourthPractical_MyTestLibrary
{
    public class Calculator
    {
        public double Add (double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            double result = 0;
            try
            {
                result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
            return a / b;
        }
    }
}
