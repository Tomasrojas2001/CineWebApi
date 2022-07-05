using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands
{
    public interface IGenericsRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(int _id) where T : class;
        void Update<T>(int id, T NewEntity) where T : class;
    }
}
