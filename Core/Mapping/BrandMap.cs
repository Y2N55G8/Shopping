using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand> 
    {

        public BrandMap()
        {
            HasKey(t => t.B_no);
            Property(t => t.B_name).IsRequired().HasColumnType("nvarchar");
            Property(t => t.B_Log).HasColumnType("nvarchar").HasMaxLength(200);
            Property(t => t.B_order).HasColumnType("int");

            ToTable("Brand");
        }
    }
}
