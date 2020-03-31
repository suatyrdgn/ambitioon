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
    public class CategoryRepository : IRepository<Category>
    {
        CelestialEntities db = DBTool.DBInstance;

        public void Delete(int itemID)
        {
            db.Categories.Remove(db.Categories.Find(itemID));
            db.SaveChanges();
        }

        public void Insert(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public List<Category> SelectAll()
        {
            return db.Categories.ToList();
        }

        public Category SelectByID(int itemID)
        {
            return db.Categories.Find(itemID);
        }

        public void Update(Category item)
        {
            Category updating = db.Categories.Find(item.ID);
            db.Entry(updating).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
