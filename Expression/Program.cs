using Bogus;
using System.Linq.Expressions;

namespace ExpressionTest;

public static class Program
{
    static void Main()
    {
        var teste = Expression.Parameter(typeof(Student), "student");
    }
}

public class Student
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public Student(string name, string lastName, int age, string city)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        City = city;
    }
}

public static class StudentGenerator
{
    public static List<Student> GetStudents()
        => new Faker<Student>()
            .CustomInstantiator(c =>
            new Student(c.Name.FirstName(), c.Name.LastName(), c.Random.Int(10, 30), c.Name.Locale))
            .Generate(10);
}