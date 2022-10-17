public int Bad(SqlConnection conn, string username, string newEmail)
{
    SqlCommand command = conn.CreateCommand();
    string updateQuery = "UPDATE Account SET [email]=" + newEmail + " WHERE user=" + username;
    command.CommandText = updateQuery;

    int rowsAffected = 0;
    try
    {
        rowsAffected = command.ExecuteNonQuery();
    }
    finally
    {
    }
    return rowsAffected;
}