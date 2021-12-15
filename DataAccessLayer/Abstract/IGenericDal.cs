using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Inset(T t);
        void Delete(T t);
        void Update(T t);
        List<T>GelListAll();
        T GetById(int id);
        List<T> GetListAllById(Expression<Func<T, bool>> filter);
    }
}
