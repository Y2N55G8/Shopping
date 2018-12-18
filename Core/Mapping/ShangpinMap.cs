using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ShangpinMap:EntityTypeConfiguration<Shangpin>
    {
        public ShangpinMap()
        {
            HasKey(t => t.S_no);
            Property(t => t.S_name).IsRequired();
            Property(t => t.S_number).IsRequired();
            Property(t => t.C_no).IsRequired();
            Property(t => t.B_no).IsRequired();
            Property(t => t.S_costprice).IsRequired();
            Property(t => t.S_marketprice).IsRequired();
            Property(t => t.S_myprice).IsRequired();
            Property(t => t.S_weight).IsRequired();
            Property(t => t.S_count).IsRequired();
            Property(t => t.S_max).IsRequired();
            Property(t => t.S_flag).IsRequired();
            Property(t => t.S_label);
            Property(t => t.S_isHot).IsRequired();
            Property(t => t.S_order);
            Property(t => t.S_xx).HasColumnType("text");

            ToTable("Shangpin");
            HasRequired(t => t.Classfiy).WithMany(t => t.Shangpins).HasForeignKey(t => t.C_no);
            HasRequired(t => t.Brand).WithMany(t => t.Shangpins).HasForeignKey(t => t.B_no);

        }
    }
}
