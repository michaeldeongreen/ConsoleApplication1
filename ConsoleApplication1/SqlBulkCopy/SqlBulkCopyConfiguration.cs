using System.Data;

namespace ConsoleApplication1.SqlBulkCopy
{
    public class SqlBulkCopyConfiguration
    {
        public string ConnectionString { get; set; }
        public int BatchSize { get; set; }
        public DataTable DataTable { get; set; }
        public string TableName { get; set; }
    }
}
