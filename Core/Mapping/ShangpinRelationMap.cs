using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class ShangpinRelationMap:EntityTypeConfiguration<ShangpinRelation>
    {
        public ShangpinRelationMap()
        {
            HasKey(t => t.SR_no);
            Property(t => t.S_no).IsRequired();
            Property(t => t.SR_sno).IsRequired();

            ToTable("ShangpinRelation");
            HasRequired(t => t.Shangpin).WithMany(t => t.ShangpinRelations).HasForeignKey(t => t.S_no);
            HasRequired(t => t.Shangpin).WithMany(t => t.ShangpinRelations).HasForeignKey(t => t.SR_sno);
        }
    }
}
