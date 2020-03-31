using DataAccess.Context;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StrategyPatterm
{
    public class MyStrategy: DropCreateDatabaseIfModelChanges<CelestialEntities>
    {
        protected override void Seed(CelestialEntities context)
        {


            var category = new List<Category>
            {
                new Category{CategoryName="Pulsar"},
                new Category{CategoryName="Star" }
            };

            var cor = new List<CelestialObject>
            {
                new CelestialObject{ Name= "rock", ID=2}
            };

            //base.Seed(context);
            //Model değişirse silip yeniden yaratmasını sağlayan sınıfımız DropCreateDatabaseIfModelChanges sınıfıdır. Bu sınıf sizden bir generic tip ister. Bu da hangi context sınıfı ile tanımlama yaptıysanız o contexti vermek zorundasınız.
        }
    }
}