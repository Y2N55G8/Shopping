using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class BrandClassMap:EntityTypeConfiguration<BrandClass>
    {
        public BrandClassMap()
        {
            HasKey(t => t.BC_no);
            Property(t => t.B_no).IsRequired();
            Property(t => t.C_no).IsRequired();
            ToTable("BrandClass");
            HasRequired(t => t.Classfiy).WithMany(t => t.BrandClass).HasForeignKey(t => t.C_no);
            HasRequired(t => t.Brand).WithMany(t => t.BrandClasses).HasForeignKey(t => t.B_no);
        }
    }
}
