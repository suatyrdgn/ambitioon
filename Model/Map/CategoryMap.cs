using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class CategoryMap:MapBase<Category>
    {
        public CategoryMap()
        {
            Property(p => p.CategoryName).HasColumnName("Category Name").HasMaxLength(100).IsRequired();
            Property(p => p.Description).HasColumnName("Description").HasMaxLength(300).IsOptional();
            Property(p => p.ParentID).HasColumnName("ParentCategoryID").IsOptional();
        }
    }
}
