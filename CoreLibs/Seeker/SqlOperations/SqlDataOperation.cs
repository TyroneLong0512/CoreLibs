using Seeker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeker.SqlOperations
{
    public class SqlDataOperation : IDataOperation
    {
        private IDataContext _dataContext;

        public SqlDataOperation(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IJoinOperation Delete<TModel>(TModel model) where TModel : class, new()
        {
            throw new NotImplementedException();
        }

        public IJoinOperation Select<TModel>(TModel model) where TModel : class, new()
        {
            throw new NotImplementedException();
        }

        public IJoinOperation Update<TModel>(TModel model) where TModel : class, new()
        {
            throw new NotImplementedException();
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }
    }
}
