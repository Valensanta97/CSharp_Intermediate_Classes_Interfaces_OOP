
namespace DesignDatabaseConnection;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Open()
    {
       Console.WriteLine("Open Connection for Sql Database");
    }

    public override void Close()
    {
        Console.WriteLine("Close Connection for Sql Database");
    }
}

