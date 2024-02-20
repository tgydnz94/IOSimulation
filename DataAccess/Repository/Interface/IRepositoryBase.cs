using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IRepositoryBase<TModel> where TModel : BaseModel
    {
        List<TModel> GetAll(Expression<Func<TModel, bool>> filter = null);
        TModel Get(Expression<Func<TModel, bool>> filter);
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
    }
}
