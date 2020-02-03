using System;
using MySql.Data.MySqlClient;

namespace podcast_book.Infra
{
    public class AppDatabase : IDisposable
    {
        public MySqlConnection Connection { get; }

        public AppDatabase(String connectionString)
        {
            Connection = new MySqlConnection("server=127.0.0.1;user id=root;password=;port=3306;Database=podcast_book;");
        }

        public void Dispose() => Connection.Dispose();
    }
}
