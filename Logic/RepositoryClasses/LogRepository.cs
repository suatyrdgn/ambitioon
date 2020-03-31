using DataAccess.Context;
using Logic.RepositoryPattern;
using Logic.SingletonPattern;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.RepositoryClasses
{
    public class LogRepository : IRepository<Log>
    {
        CelestialEntities db = DBTool.DBInstance;

        public void Delete(int itemID)
        {
            throw new NotImplementedException();  // kullanıcı sildiği zaman discontinued ile kullanıcı göremeyecek ama yetkililer görebilecek
        }

        public void Insert(Log item)
        {
            db.Logs.Add(item);
            db.SaveChanges();
        }

        public List<Log> SelectAll()
        {
            return db.Logs.ToList();
        }

        public Log SelectByID(int itemID)
        {
            return db.Logs.Find(itemID);
        }

        public void Update(Log item)
        {
            Log updating = db.Logs.Find(item.ID);
            db.Entry(updating).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
