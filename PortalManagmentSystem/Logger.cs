namespace PortalManagmentSystem;
public class Logger
{
    public readonly string _logFilePath;
    public Logger(string path)
    {
        _logFilePath = path;
    }
    public void LogError(string message)
    {
        File.WriteAllText(_logFilePath, message);
    }
}
