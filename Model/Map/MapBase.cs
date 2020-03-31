using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class MapBase<T>:EntityTypeConfiguration<T> where T:EntityBase
    {
        public MapBase()
        {
            Property(p => p.ActionDate).HasColumnType("datetime2").HasColumnName("Added Date").IsOptional();
        }
    }
}
