namespace DapperBD
{
    public interface IOrmNameProvider
    {
        string GetColumnName(string propertyName);
    }
}
