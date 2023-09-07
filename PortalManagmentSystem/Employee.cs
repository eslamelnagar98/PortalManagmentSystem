namespace PortalManagmentSystem;
//Implment Single Responsabiltiy For This Class , Make Save Method Single Responsable (It Has More Reason To Change)
// Some Tips (Trying To Segregate Logging Mechanism From Save Method)
//This Class Is Managed By Too Many People (CalculatePay Method Is Requested and Managed By The CFO ,
//Save Method Is Request And Managed By The CTO , ReportHours Method Is Requested And Managed By COO) 
//Any Change In CalculatePay  Will Affect ReportHours And COO Will Complain And Will Request To Reimplment The CalculatePay,
//And So On, So We Need To Separate Every Class
public class Employee
{
    public double CalculatePay(Employee empolyee)
    {
        return default;
    }

    public void Save(Employee emp)
    {
        try
        {

        }
        catch (Exception exception)
        {
            File.WriteAllText(@"G:\Technical Data", exception.Message);
        }
    }

    public string ReportHours(Employee employee)
    {
        return default;
    }
}
