namespace DesignDatabaseConnection;

public abstract class DbConnection
{
    private string ConnectionString { get; set; }
    
    private TimeSpan Timeout { get; set; }

    protected DbConnection(string connectionString)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(connectionString);
        ConnectionString = connectionString;
    }

    public abstract void Open();
    
    public abstract void Close();
    
}