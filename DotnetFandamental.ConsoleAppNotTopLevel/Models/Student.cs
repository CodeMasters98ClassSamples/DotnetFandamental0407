namespace DotnetFandamental.ConsoleAppNotTopLevel.Models;

internal class Student  //قالب
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }
    public string PhoneNumber { get; set; }
    public int Age { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public bool IsValidAge()
    {
        return Age <= 10 || Age > 100;
    }
}
