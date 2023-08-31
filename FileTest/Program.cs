namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\00WORK\Test";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = $"test-backup-{DateTime.Now}.txt";
            //create new file with text in it
            File.WriteAllText(Path.Combine(path, "test.txt"), "This is test document");

            //copy file 
            FileInfo file = new FileInfo(@"C:\00WORK\Test\test.txt");

            file.CopyTo(@"C:\Test\test.txt", true); 
        }
    }
}