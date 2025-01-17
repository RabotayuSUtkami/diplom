namespace iLearning
{
    internal class SQLiteConnection
    {
        private string connectionString;

        public SQLiteConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}