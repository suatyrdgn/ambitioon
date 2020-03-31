using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Map
{
    public class LogMap:MapBase<Log>
    {
        public LogMap()
        {
            Property(p => p.Action).HasColumnName("Action").IsRequired();
            Property(p => p.Description).HasColumnName("ActionDescription").HasMaxLength(300).IsRequired();
            Property(p => p.ActionDate).HasColumnName("Action Date").IsRequired();
            Property(p => p.Username).HasColumnName("User").IsRequired();
        }
    }
}
