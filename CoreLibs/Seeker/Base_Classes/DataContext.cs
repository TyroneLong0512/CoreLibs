using Seeker.Interfaces;

namespace Seeker.Base_Classes
{
    /// <summary>
    /// Base class that implements <see cref="IDataContext"/>
    /// </summary>
    public class DataContext : IDataContext
    {
        public string ConnectionString { get; }
        public string DataBase { get; }

        public DataContext(string connectionString, string dataBase)
        {
            ConnectionString = connectionString;
            DataBase = dataBase;
        }
    }
}
