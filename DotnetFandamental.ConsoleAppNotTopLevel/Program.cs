using DotnetFandamental.ConsoleAppNotTopLevel.Models;

namespace DotnetFandamental.ConsoleAppNotTopLevel;

internal class Program
{
    static void Main(string[] args)
    {

        try
        {
            //DataType nameVaribale = initialValue;
            int num1 = 0; //Premitive Data -> DataType nameVaribale = initialValue;
            Student student = new Student();
            do
            {
                Console.WriteLine("What is your phoneNumber?");
                student.PhoneNumber = Console.ReadLine() ?? "";
                student.PhoneNumber = FormatMobileNumber(student.PhoneNumber);
                if (IsValidMobileNumber(student.PhoneNumber))
                    break;
                else
                    Console.WriteLine("Invalid phoneNumber. Please enter valid phoneNumber!");
            } while (true);

           
            string helloWorldText = "Hello, World!";
            Console.WriteLine(helloWorldText);

            Console.WriteLine("What is your first name?");
            do
            {
                student.FirstName = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(student.FirstName) || student.FirstName.Length <= 2)
                    Console.WriteLine("Invalid firstName. Please enter valid name!");
                else
                    break;
            } while (true);

            Console.WriteLine("What is your last name?");
            while (true)
            {
                student.LastName = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(student.LastName) || student.LastName.Length <= 2)
                    Console.WriteLine("Invalid lastName. Please enter valid lastName!");
                else
                    break;
            }

            Console.WriteLine(student.GetFullName());

            Console.WriteLine("How old are you?");
            string ageStr = "";
            while (true)
            {
                ageStr = Console.ReadLine() ?? "";
                student.Age = int.Parse(ageStr);
                if (student.IsValidAge())
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
