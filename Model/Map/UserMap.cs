using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class UserMap:MapBase<User>
    {
        public UserMap()
        {
            Property(p => p.Username).HasColumnName("User Name").IsRequired();
        }
    }
} 