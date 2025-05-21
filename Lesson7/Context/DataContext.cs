using System.Text.Json;
using Lesson7.Models;

namespace Lesson7.Context;

public static class DataContext
{
    public static List<Employee>? GetEmployees()
    {
        var employees = new List<Employee>();
        var file = File.ReadAllText("employees.json");

        employees = JsonSerializer.Deserialize<List<Employee>>(file);

        return employees;
    }
}