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
    public class UserRepository : IRepository<User>
    {
        CelestialEntities db = DBTool.DBInstance;

        public void Delete(int itemID)
        {
            db.Users.Remove(db.Users.Find(itemID));
            db.SaveChanges();
        }

        public void Insert(User item)
        {
            db.Users.Add(item);
            db.SaveChanges();
        }

        public List<User> SelectAll()
        {
            return db.Users.ToList();
        }

        public User SelectByID(int itemID)
        {
            return db.Users.Find(itemID);
        }

        public void Update(User item)
        {
            User updating = db.Users.Find(item.ID);
            db.Entry(updating).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
