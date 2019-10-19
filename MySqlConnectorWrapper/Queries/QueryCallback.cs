namespace Pustalorc.Libraries.MySqlConnectorWrapper.Queries
{
    /// <summary>
    ///     Callback for any queries that finished execution and required a return value.
    /// </summary>
    /// <param name="queryOutput">The output of the executed query, including the query object.</param>
    public delegate void QueryCallback(QueryOutput queryOutput);
}