namespace DotnetFandamental.ConsoleAppNotTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Varibale
            //Type(نوع) nameOfVaribale = intialValue(مقدار دهی اولیه);
            string helloWorldText = "Hello, World!";
            Console.WriteLine(helloWorldText);

            bool isRegisted = true;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("your name is: " + name);

        }
        
    }
}
