using System.Text;

namespace TrainingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("[1] Genterate random number [2] Genterate random string");
                string SelectOption = Console.ReadLine();
                if (SelectOption == "1")
                    GenerateRandomNumber();
               
                else if (SelectOption == "2")
                    GenerateRandomString();
                Console.WriteLine("-----------------------------------------------");
            }
        }
        static void GenerateRandomNumber()
        {
            var rnd = new Random();
            var value = rnd.Next(1000, 9999);
            Console.WriteLine($"Random Number: {value}");
        }
        private const string words = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$@%^&*~!()";
        static void GenerateRandomString()
        {
            var sb = new StringBuilder();
            var rnd= new Random();
            while (sb.Length < 16)
            {
                var RandomIndex = rnd.Next(0, words.Length - 1);
                sb.Append(words[RandomIndex]);
            }
            Console.WriteLine($"Random string: {sb}");
        }
    }
}
