using System.Text.Json.Serialization;

namespace Lesson7.Models;

public class Person
{
    [JsonPropertyName("last_name")]
    public string LastName   { get; set; }
    [JsonPropertyName("first_name")]
    public string FirstName   { get; set; }
    [JsonPropertyName("middle_name")]
    public string MiddleName   { get; set; }

    public Person(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }
}