namespace LogIn_Master.Models;


public class Student
{
    public string? Username { get; set; }
    public string? Password { get; set; }


    public Student(string? username, string? password)
    {
        Username = username;
        Password = password;
    }
}