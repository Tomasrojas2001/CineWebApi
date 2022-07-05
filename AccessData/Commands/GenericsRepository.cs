using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Commands
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly CineContext ctx;
        public GenericsRepository(CineContext dbContext)
        {
            ctx = dbContext;
        }

        public void Add<T>(T entity) where T : class
        {

            ctx.Add(entity);
            ctx.SaveChanges();

        }
        public void Delete<T>(int _id) where T : class
        {
            ctx.Remove(ctx.Find<T>(_id));
            ctx.SaveChanges();
        }
        public void Update<T>(int id,T NewEntity) where T : class
        {
            var entity = ctx.Find<T>(id);

            ctx.Entry(entity).CurrentValues.SetValues(NewEntity);
            ctx.SaveChanges();
        }
    }
}
