namespace MortgageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much are you borrowin?  ");
            double amountBorrowed = double.Parse(Console.ReadLine());

            Console.Write("What is your interest rate?  ");
            double annualInterestRate = double.Parse(Console.ReadLine());

            Console.Write("How long is your loan (in years)?  ");
            int loanYears = int.Parse(Console.ReadLine());
          

            double monthlyInterestRates = annualInterestRate / 12;
            int loanMonths = loanYears * 12;

            double monthlyPayment = CalculateMonthlyPayment(amountBorrowed, annualInterestRate, loanMonths);
            //double totalPaid = monthlyPayment * loanMonths;
            //double totaInterest = totalPaid - amountBorrowed;


            //double numerator = amountBorrowed * monthlyInterestRates;
            //double denominator = 1 - Math.Pow((1 + monthlyInterestRates), -loanMonths);
            //double monthlyPayment = amountBorrowed * ((monthlyInterestRates * (Math.Pow(1 + monthlyInterestRates, loanMonths))) / (Math.Pow(1 + monthlyInterestRates, loanMonths) - 1));
            double lifeLoan = amountBorrowed * loanYears;
            double totalInterest = annualInterestRate * loanYears;


            Console.WriteLine($"Your estimated payment is {monthlyPayment:F2}  ");
            Console.WriteLine($"You paid {lifeLoan:F2} over the life of the loan  ");
            Console.WriteLine($"Your total interest cost for the loan was {totalInterest:F2}  ");


        }

        static double CalculateMonthlyPayment(double pricipal, double monthlyRate, int months)
        {
            //double  denominator = Math.Pow(1+monthlyRate, months)-1;
            //double fraction = (monthlyRate * Math.Pow(1 + monthlyRate, months)) / denominator;
            //return pricipal * fraction;
            return pricipal * ((monthlyRate * (Math.Pow(1 + monthlyRate, months))) / (Math.Pow(1 + monthlyRate, months) - 1));

        }
        

        }
    } 
