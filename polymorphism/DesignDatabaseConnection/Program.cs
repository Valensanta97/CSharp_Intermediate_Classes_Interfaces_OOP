namespace DesignDatabaseConnection;

class Program
{
    static void Main(string[] args)
    {
        var sqlConnection = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        sqlConnection.Open();
        sqlConnection.Close();
        
        var sqlConnectionNullException = new SqlConnection(null);
        sqlConnectionNullException.Open();
        sqlConnectionNullException.Close();
    }
}