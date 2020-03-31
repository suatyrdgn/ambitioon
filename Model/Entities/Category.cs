using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Category : EntityBase, IDatabase
    {
        [Required]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //mapping
        public int? ParentID { get; set; }

        public virtual List<CelestialObject> CelestialObjects { get; set; }
        public virtual List<Category> SubCategory { get; set; }
    }
} 