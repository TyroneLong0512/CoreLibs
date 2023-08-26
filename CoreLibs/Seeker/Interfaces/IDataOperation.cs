namespace Seeker.Interfaces
{
    /// <summary>
    /// Defines which data operation should be used
    /// </summary>
    public interface IDataOperation
    {
        /// <summary>
        /// Creates a selection query to the given database
        /// </summary>
        /// <typeparam name="TModel">A POCO</typeparam>
        /// <param name="model">The model that you would like to query for</param>
        /// <returns><see cref="IJoinOperation"/></returns>
        IJoinOperation Select<TModel>(TModel model) where TModel : class, new();

        /// <summary>
        /// Creates an update query to the given database
        /// </summary>
        /// <typeparam name="TModel">A POCO</typeparam>
        /// <param name="model">The model that you would like to query for</param>
        /// <returns><see cref="IJoinOperation"/></returns>
        IJoinOperation Update<TModel>(TModel model) where TModel : class, new();

        /// <summary>
        /// Creates a delete query to the given database
        /// </summary>
        /// <typeparam name="TModel">A POCO</typeparam>
        /// <param name="model">The model that you would like to query for</param>
        /// <returns><see cref="IJoinOperation"/></returns>
        IJoinOperation Delete<TModel>(TModel model) where TModel : class, new();

        /// <summary>
        /// Commits all created data operations on the instance
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Commit();
    }
}
