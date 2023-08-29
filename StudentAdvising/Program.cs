namespace StudentAdvising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name, major, classification;
                GetData(out name, out major, out classification);
                //Console.WriteLine($"{name},{major},{classification}");
                string location = GetAdvisingLocation(major, classification);
                Console.WriteLine($"Advising for {major} {classification}: {location}");



                Console.WriteLine("Do you want to enter another?");
                string input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    Environment.ExitCode = 0;
                    break;
                }
            }
        }



        public static void GetData(out string name, out string major, out string classification)
        {
            Console.WriteLine("What is the student's name");
            name = Console.ReadLine();



            Console.WriteLine("What is the student's major");
            major = Console.ReadLine();



            Console.WriteLine("What is the student's classification");
            classification = Console.ReadLine();
        }



        public static string GetAdvisingLocation(string major, string classification)
        {
            switch (major.ToLower(), classification.ToLower())
            {
                case ("biol", "freshman"):
                    return "Science Bldg, Room 310";
                case ("biol", "sophomore"):
                    return "Science Bldg, Room 310";
                case ("biol", "junior"):
                    return "Science Bldg, Room 311";
                case ("biol", "senior"):
                    return "Science Bldg, Room 311";



                case ("csci", _):
                    return "Sheppard Hall, Room 314";



                case ("eng", "freshman"):
                    return "Kerr Hall, Room 201";
                case ("eng", "sophomore"):
                    return "Kerr Hall, Room 312";
                case ("eng", "senior"):
                    return "Kerr Hall, Room 312";



                case ("hist", _):
                    return "Kerr Hall, Room 114";



                case ("mkt", "freshman"):
                    return "Westly Hall, Room 310";
                case ("mkt", "junior"):
                    return "Westly Hall, Room 310";
                case ("mkt", "senior"):
                    return "Westly Hall, Room 313";



                default:
                    return "Major not found";
            }
        }
    }
    }
