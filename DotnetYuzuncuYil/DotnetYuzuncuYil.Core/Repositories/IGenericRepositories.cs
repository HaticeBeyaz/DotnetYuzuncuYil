using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Repositories
{
    public interface IGenericRepositories<T>where T : class //temsili genericrepo her entity i karşılayabilsin diye
    {
        Task<T> GetByIdaAsync(int id);//1.36 dakikaya bak açıklama yaz
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression);
        IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task AddAsync(T entity); //asenkron metot (model ekleyebiliriz.)
        Task AddRangeAsync(IEnumerable<T> entities); //birden fazla data eklemek veya liste göndermek istediğimizde bu şekilde ekleriz.
        void Update(T entity);  
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
