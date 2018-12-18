using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class AttributeValueMap:EntityTypeConfiguration<AttributeValue>
    {
        public AttributeValueMap()
        {
            HasKey(t => t.AV_no);
            Property(t => t.AV_name).IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(t => t.A_no).IsRequired().HasColumnType("int");
            Property(t => t.A_order).HasColumnType("int");

            ToTable("AttributeValue");
            HasRequired(t => t.Attribute).WithMany(t => t.AttributeValue).HasForeignKey(t => t.A_no);
        }
    }
}
