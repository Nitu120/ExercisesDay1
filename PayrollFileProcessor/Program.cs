namespace PayrollFileProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the input file name: ");
                string inputFileName = Console.ReadLine();

                string outputFileName1 = "Payroll1.txt";
                string outputFileName2 = "Payroll2.txt";
                string logFileName = "PayrollFileProcessor.log";

                try
                {
                    using (StreamReader reader = new StreamReader(inputFileName))
                    using (StreamWriter writer1 = new StreamWriter(outputFileName1))
                    using (StreamWriter writer2 = new StreamWriter(outputFileName2))
                    using (StreamWriter logWriter = new StreamWriter(logFileName, true))
                    {
                        double grossPayTotal = 0.0;

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Length >= 35)
                            {
                                string employeeId = line.Substring(0, 5).Trim();
                                string name = line.Substring(5, 20).Trim();
                                double payRate = double.Parse(line.Substring(25, 5));
                                double hoursWorked = double.Parse(line.Substring(30, 5));

                                double overtimeHours = Math.Max(0, hoursWorked - 40);
                                double regularHours = hoursWorked - overtimeHours;
                                double totalPay = (regularHours * payRate) + (overtimeHours * payRate * 1.5);

                                grossPayTotal += totalPay;

                                string payrollRecord = $"{employeeId,-5} {name,-20} {payRate,6:C} {hoursWorked,5} {totalPay,10:C}";

                                writer1.WriteLine(payrollRecord);
                                writer2.WriteLine(payrollRecord);
                            }
                        }

                        string logMessage = $"Processing file: {inputFileName} on {DateTime.Now:MM-dd-yyyy} at {DateTime.Now:hh:mm:ss tt}";
                        logMessage += Environment.NewLine + $"Gross pay totals were {grossPayTotal:C}";
                        logWriter.WriteLine(logMessage);

                        Console.WriteLine("Payroll data processed and saved successfully!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}