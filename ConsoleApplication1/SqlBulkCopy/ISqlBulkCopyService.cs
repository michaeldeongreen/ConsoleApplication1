namespace ConsoleApplication1.SqlBulkCopy
{
    public interface ISqlBulkCopyService
    {
        void Save(SqlBulkCopyConfiguration configuration);
    }
}
