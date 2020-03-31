using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class CelestialMap:MapBase<CelestialObject>
    {
        public CelestialMap()
        {
            Property(p => p.Name).HasColumnName("Celestial Object Name").HasMaxLength(200).IsRequired();
            Property(p => p.Description).HasColumnName("Description").HasMaxLength(300).IsOptional();
            Property(p => p.CategoryID).HasColumnName("CategoryID").IsRequired();
        }
    }
}
