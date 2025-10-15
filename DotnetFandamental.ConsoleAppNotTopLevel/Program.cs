namespace DotnetFandamental.ConsoleAppNotTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            string helloWorldText = "Hello, World!";
            Console.WriteLine(helloWorldText);

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine() ?? "";

            if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
            {
                Console.WriteLine("Invalid firstName");
            }
            else
            {
                Console.WriteLine("valid firstName");
            }

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine() ?? "";

            Console.WriteLine($"my name is: {firstName} {lastName}");

            Console.WriteLine("How old are you?");
            string ageStr = Console.ReadLine() ?? "";
            int age = int.Parse(ageStr);
            Console.WriteLine("age: " + age);

            Console.WriteLine("What is your phoneNumber?");
            string phoneNumber = Console.ReadLine() ?? "";
            Console.WriteLine("phoneNumber: " + phoneNumber);

        }

    }
}
