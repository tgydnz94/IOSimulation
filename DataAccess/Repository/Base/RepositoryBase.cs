using DataAccess.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Base
{
    public class RepositoryBase<TModel, TContext> : IRepositoryBase<TModel>
                                                    where TModel : BaseModel
                                                    where TContext : DbContext, new()
    {
        public void Add(TModel model)
        {
            using (TContext context = new TContext())
            {
                var addedModel = context.Entry(model);
                addedModel.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TModel model)
        {
            using (TContext context = new TContext())
            {
                var deletedModel = context.Entry(model);
                deletedModel.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TModel Get(Expression<Func<TModel, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TModel>().SingleOrDefault(filter);
            }
        }

        public List<TModel> GetAll(Expression<Func<TModel, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TModel>().ToList()
                    : context.Set<TModel>().Where(filter).ToList();

            }
        }

        public void Update(TModel model)
        {
            using (TContext context = new TContext())
            {
                var updatedModel = context.Entry(model);
                updatedModel.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
