using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Core.Mapping
{
    public class AttributeGroupMap : EntityTypeConfiguration<AttributeGroup>
    {
        public AttributeGroupMap()
        {
            HasKey(x => x.AG_no);
            Property(x => x.AG_name).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.C_no).IsRequired().HasColumnType("int");
            Property(x => x.AG_order).HasColumnType("int");
            ToTable("AttributeGroup");
            HasRequired(t => t.Classfiy).WithMany(t => t.AttributeGroups).HasForeignKey(t => t.C_no);
        }
    }
}
