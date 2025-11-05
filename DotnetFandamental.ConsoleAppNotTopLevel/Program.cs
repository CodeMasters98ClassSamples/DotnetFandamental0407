using static System.Net.Mime.MediaTypeNames;

namespace DotnetFandamental.ConsoleAppNotTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Collection
            string text = "apple,banana,grape";

            string[] fruits = text.Split(',');

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            try
            {
                do
                {
                    string str = "asdasda";
                    str.Replace("World", "C#");
                    Console.WriteLine("What is your phoneNumber?");
                    string phoneNumber = Console.ReadLine() ?? "";
                    phoneNumber = FormatMobileNumber(phoneNumber);
                    if (IsValidMobileNumber(phoneNumber))
                        break;
                    else
                        Console.WriteLine("Invalid phoneNumber. Please enter valid phoneNumber!");
                } while (true);

               
                string helloWorldText = "Hello, World!";
                Console.WriteLine(helloWorldText);

                Console.WriteLine("What is your first name?");
                string firstName = "";
                do
                {
                    firstName = Console.ReadLine() ?? "";
                    if (string.IsNullOrEmpty(firstName) || firstName.Length <= 2)
                        Console.WriteLine("Invalid firstName. Please enter valid name!");
                    else
                        break;
                } while (true);

                Console.WriteLine("What is your last name?");
                string lastName = "";
                while (true)
                {
                    lastName = Console.ReadLine() ?? "";
                    if (string.IsNullOrEmpty(lastName) || lastName.Length <= 2)
                        Console.WriteLine("Invalid lastName. Please enter valid lastName!");
                    else
                        break;
                }

                Console.WriteLine($"my name is: {firstName} {lastName}");

                Console.WriteLine("How old are you?");
                string ageStr = "";
                while (true)
                {
                    ageStr = Console.ReadLine() ?? "";
                    int age = int.Parse(ageStr);
                    if (age <= 10 || age > 100)
                        Console.WriteLine("Invalid age. Please enter valid age!");
                    else
                        break;
                }

            }
            catch (Exception ex)
            {
                //Business of log
                throw;
            }

        }


        //Method Overload
        //DRY -> Dont repeat yourself
        //static int Sum(int a1, int a2)
        //{
        //    int result = a1 + a2;
        //    return result;
        //}

        

        static bool IsValidMobileNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            if (phoneNumber.Length == 11 && phoneNumber.StartsWith('0'))
                return true;
            else
                return false;
        }


        /// <summary>
        ///sadjkfajsdfbfj 
        /// </summary>
        /// <param name="phoneNumber">sadhkasj</param>
        /// <returns>i will return correct phonenumber format</returns>
        static string FormatMobileNumber(string phoneNumber)
        {
            //Reusable Code
            //9129564205 -> 09129564205
            if (phoneNumber.Length == 10 && !phoneNumber.StartsWith('0'))
            {
                phoneNumber = "0" + phoneNumber;
            }

            //989129564205 -> 09129564205
            if (phoneNumber.Length == 12 && phoneNumber.StartsWith("98"))
            {
                phoneNumber = phoneNumber.Replace("98", "0");
            }

            return phoneNumber; 
        }

    }
}
