using System.Linq.Expressions;

namespace Seeker.Interfaces
{
    /// <summary>
    /// Handles join operations for the given IDataOperation object
    /// </summary>
    public interface IJoinOperation
    {
        /// <summary>
        /// Joins the model referenced in IDataOperation to a different model
        /// </summary>
        /// <typeparam name="TModel">A POCO of a different type than is referenced in the IDataOperation</typeparam> 
        /// <param name="model">An instance of a specific model <see cref="{TModel}"/></param>
        /// <returns><see cref="IJoinOperation"/></returns>
        IJoinOperation Join<TModel>(TModel model) where TModel : class, new();

        /// <summary>
        /// Creates a where clause on the models joined or called.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="model"></param>
        /// <returns><see cref="IWhereOperation"/></returns>
        IWhereOperation Where<TModel>(Expression<Func<TModel, bool>> whereExpression) where TModel : class, new();
    }
}
