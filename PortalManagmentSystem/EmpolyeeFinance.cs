namespace PortalManagmentSystem;
public class EmpolyeeFinance
{
    public virtual double CalculatePay(Employee employee)
    {
        if (employee.EmployeeType is EmployeeType.FullTime)
        {
            return employee.TotalHoursWorked * 100;
        }

        if (employee.EmployeeType is EmployeeType.PartTime)
        {
            return employee.TotalHoursWorked * 50;
        }

        return 10;
    }


}
