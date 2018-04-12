using System;
using System.Data.SqlClient;


namespace ConsoleApplication1.SqlBulkCopy
{
    public class SqlBulkCopyService : ISqlBulkCopyService
    {
        public void Save(SqlBulkCopyConfiguration configuration)
        {
            using (var connection = new SqlConnection(configuration.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (var bulkCopy = new System.Data.SqlClient.SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                {
                    bulkCopy.BatchSize = configuration.BatchSize;
                    bulkCopy.DestinationTableName = configuration.TableName;
                    try
                    {
                        foreach (var column in configuration.DataTable.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ToString(), column.ToString());
                        }
                        bulkCopy.WriteToServer(configuration.DataTable);
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
    }
}
