using AdapterPattern.Core;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

var payrollCalculateUrl = "https://localhost:7037/PayrollCalculator";
var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();
foreach(var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculateUrl);
    var employeeAdapter = new PayrollSystemPayItemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");
    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);

    Console.WriteLine($"Salary for employee '{employee.FullName}' as of today = {salary}");
}
Console.ReadKey();

