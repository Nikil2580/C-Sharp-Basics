public class MainPrograms
{
    public static void Main()
    {
        EmployeeDetails employeeDetails = new EmployeeDetails();
        employeeDetails.EmployeeName = "Nikil";
        employeeDetails.EmployeeSalary = 98000;
        Console.WriteLine($"Employee Name: {employeeDetails.EmployeeName}");
        Console.WriteLine($"Employee Salary: {employeeDetails.EmployeeSalary}");
    }
}