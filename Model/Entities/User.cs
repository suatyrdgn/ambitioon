using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User : EntityBase, IDatabase
    {
        [Required]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Log> Actions { get; set; }
    }
}
