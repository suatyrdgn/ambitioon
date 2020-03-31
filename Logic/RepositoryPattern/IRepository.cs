using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.RepositoryPattern
{
    public interface IRepository<T> where T:class 
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemID);
        T SelectByID(int itemID);
        List<T> SelectAll();
    }
}
