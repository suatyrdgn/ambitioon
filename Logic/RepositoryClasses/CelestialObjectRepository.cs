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
    public class CelestialObjectRepository : IRepository<CelestialObject>
    {
        CelestialEntities db = DBTool.DBInstance;

        public void Delete(int itemID)
        {
            db.CelestialObjects.Remove(db.CelestialObjects.Find(itemID));
            db.SaveChanges();
        }

        public void Insert(CelestialObject item)
        {
            db.CelestialObjects.Add(item);
            db.SaveChanges();
        }

        public List<CelestialObject> SelectAll()
        {
            return db.CelestialObjects.ToList();
        }

        public CelestialObject SelectByID(int itemID)
        {
            return db.CelestialObjects.Find(itemID);
        }

        public void Update(CelestialObject item)
        {
            CelestialObject updating = db.CelestialObjects.Find(item.ID);
            db.Entry(updating).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
