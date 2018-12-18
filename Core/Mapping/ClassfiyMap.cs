using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ClassfiyMap:EntityTypeConfiguration<Classfiy>
    {
        public ClassfiyMap()
        {
            HasKey(t => t.C_no);
            Property(t => t.C_name).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            Property(t => t.C_prices).HasMaxLength(300).HasColumnType("nvarchar");
            Property(t => t.C_cno).IsRequired().HasColumnType("int");
            Property(t => t.C_order).HasColumnType("int");
            ToTable("Classfiy");
           
        }
    }
}
