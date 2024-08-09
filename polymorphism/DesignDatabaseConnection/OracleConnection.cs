namespace DesignDatabaseConnection;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Open Connection for Oracle Database");
    }

    public override void Close()
    {
        Console.WriteLine("Open Connection for Oracle Database");
    }
}