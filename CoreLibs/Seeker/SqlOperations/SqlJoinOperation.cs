using Seeker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeker.SqlOperations
{
    public class SqlJoinOperation : IJoinOperation
    {
        public IJoinOperation Join<TModel>(TModel model) where TModel : class, new()
        {
            throw new NotImplementedException();
        }

        public IWhereOperation Where<TModel>(TModel model) where TModel : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
