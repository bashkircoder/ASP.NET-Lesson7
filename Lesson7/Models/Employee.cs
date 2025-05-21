using System.Text.Json.Serialization;

namespace Lesson7.Models;

public class Employee : Person
{
    [JsonPropertyName("position")]
    public string Position { get; set; }
    [JsonPropertyName("telephone_number")]
    public string TelephoneNumber { get; set; }
    
    public Employee(string lastName, string firstName, string middleName, string position, string telephoneNumber) : base(lastName, firstName, middleName)
    {
        Position = position;
        TelephoneNumber = telephoneNumber;
    }

    public override string ToString()
    {
        return $"Должность: {Position}\nФИО: {LastName} {FirstName} {MiddleName}\nНомер телефона: {TelephoneNumber}";
    }
}