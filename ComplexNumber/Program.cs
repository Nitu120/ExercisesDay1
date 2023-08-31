namespace ComplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complex Number Operations");

            Console.Write("Enter the real part of the first complex number: ");
            double real1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the imaginary part of the first complex number: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the real part of the second complex number: ");
            double real2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the imaginary part of the second complex number: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber sum = complex1.Add(complex2);
            ComplexNumber product = complex1.Multiply(complex2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }

        class ComplexNumber
        {
            public double Real { get; }
            public double Imaginary { get; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public ComplexNumber Add(ComplexNumber other)
            {
                double newReal = Real + other.Real;
                double newImaginary = Imaginary + other.Imaginary;
                return new ComplexNumber(newReal, newImaginary);
            }

            public ComplexNumber Multiply(ComplexNumber other)
            {
                double newReal = Real * other.Real - Imaginary * other.Imaginary;
                double newImaginary = Real * other.Imaginary + Imaginary * other.Real;
                return new ComplexNumber(newReal, newImaginary);
            }
           

            public override string ToString()
            {
                if (Imaginary >= 0)
                    return $"{Real} + {Imaginary}i";
                else
                    return $"{Real} - {-Imaginary}i";
            }
        }

    }
}