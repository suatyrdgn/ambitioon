using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.SingletonPattern
{
    public class DBTool
    {

        private static CelestialEntities _dbInstance;

        public static CelestialEntities DBInstance
        {
            get
            {
                if (_dbInstance==null)
                {
                    _dbInstance = new CelestialEntities();
                }

                return _dbInstance;
            }
        }

    }
}
