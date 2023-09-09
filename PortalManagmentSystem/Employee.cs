namespace PortalManagmentSystem;
public class Employee
{
    private readonly Logger logger = new Logger(string.Empty);
    public EmployeeType EmployeeType { get; set; }
    public double TotalHoursWorked { get; set; }

    public void Save(Employee emp)
    {
        try
        {

        }
        catch (Exception exception)
        {
            logger.LogError(exception?.Message ?? string.Empty);
        }
    }

}
