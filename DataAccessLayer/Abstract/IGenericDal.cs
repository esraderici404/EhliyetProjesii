using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T item);
        void Delete (int id );
        void Update (T item);
        List<T> GetList();
        T GetById(int id);

    }
}
