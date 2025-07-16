using SingleResponsibilityPrinciple.Problem;
using SingleResponsibilityPrinciple.Solution;

public class Program
{
    public static void Main(string[] args)
    {
        // The EmployeeProblem class violates the Single Responsibility Principle as it handles both employee management and attendance management.
        EmployeeProblem employeeProblem = new EmployeeProblem(); //Add, Retrieve, Update, Delete Employee and PunchIn, PunchOut Shift

        // The EmployeeSolution and AttendanceSolution classes adhere to the Single Responsibility Principle by separating concerns.
        EmployeeSolution employeeSolution = new EmployeeSolution(); //Add, Retrieve, Update, Delete Employee
        AttendanceSolution attendanceSolution = new AttendanceSolution(); //PunchIn, PunchOut Shift
    }
}
