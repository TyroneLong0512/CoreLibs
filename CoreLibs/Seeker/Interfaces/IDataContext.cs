namespace Seeker.Interfaces
{
    /// <summary>
    /// Base interface for <see cref="Base_Classes.DataContext"/>
    /// </summary>
    public interface IDataContext
    {
        /// <summary>
        /// The ConnectionString to the Database
        /// </summary>
        string ConnectionString { get; }

        /// <summary>
        /// The name of the DataBase
        /// </summary>
        string DataBase { get; }
    }
}
