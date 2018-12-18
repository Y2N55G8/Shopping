using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Core.Mapping
{
    public class AttributeMap: EntityTypeConfiguration<Entities.Attribute>
    {
        public AttributeMap()
        {
            HasKey(t => t.A_no);
            Property(t => t.A_name).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(t => t.AG_no).IsRequired().HasColumnType("int");
            Property(t => t.A_type).IsRequired().HasColumnType("int");
            Property(t => t.A_screen).IsRequired().HasColumnType("int");
            Property(t => t.A_order).HasColumnType("int");
            ToTable("Attribute");
            HasRequired(t => t.AttributeGroup).WithMany(t=>t.Attribute).HasForeignKey(t => t.AG_no);
            
        }
    }
}
