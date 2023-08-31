namespace ClassPlay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Employee employee = new Employee("ABC","XYZ",1,2020,"New","TBC",15000);
                Employee[] employee1 = new Employee[1];
                employee1[0] = new Employee("DAvid","Tan",1,2021,"New Hire","TBD",1500);
                Console.WriteLine(employee1);
                Console.WriteLine("Displayed Employee:");
                employee.Display();
                Console.WriteLine("Promote Employee:");
                employee.Promote("Manager", 50000);



            }

            
        }
    }
}