using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ShangpinAttributeMap:EntityTypeConfiguration<ShangpinAttribute>
    {
        public ShangpinAttributeMap()
        {
            HasKey(t => t.SA_id);
            Property(t => t.SA_name).IsRequired();
            Property(t => t.SA_Value).IsRequired();
            Property(t => t.S_no).IsRequired();
            ToTable("ShangpinAttribute");
            HasRequired(t => t.Shangpin).WithMany(t => t.ShangpinAttributes).HasForeignKey(t => t.S_no);
        }
    }
}
