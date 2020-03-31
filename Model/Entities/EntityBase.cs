using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            ActionDate = DateTime.Now;
        }
        public DateTime ActionDate { get; set; }
    }
}
