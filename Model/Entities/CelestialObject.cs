using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class CelestialObject : EntityBase, IDatabase
    {
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CelestialObjectType { get; set; } // similar to category
        public int CategoryID { get; set; }
        public List<string> CelestialImagesUrl { get; set; }

        public virtual List<CelestialObject> CelestialObjectsList { get; set; }
        
    }
}
