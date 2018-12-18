using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ShangponImgMap:EntityTypeConfiguration<ShangpinImg>
    {
        public ShangponImgMap()
        {
            HasKey(t => t.SI_no);
            Property(t => t.SI_no).IsRequired();
            Property(t => t.SI_img).IsRequired();
            Property(t => t.SI_main).IsRequired();
            Property(t => t.SI_order);
            ToTable("ShangponImg");
            HasRequired(t => t.Shangpin).WithMany(t => t.ShangpinImgs).HasForeignKey(t => t.S_no);
        }
    }
}
