using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public  class ShangpinTimingMap:EntityTypeConfiguration<ShangpinTiming>
    {
        public ShangpinTimingMap()
        {
            HasKey(t => t.ST_no);
            Property(t => t.S_no).IsRequired();
            Property(t => t.ST_starttime).IsRequired().HasColumnType("DateTime");
            Property(t => t.ST_endtime).IsRequired().HasColumnType("DateTime");
            ToTable("ShangpinTiming");
            HasRequired(t => t.Shangpin).WithMany(t => t.ShangpinTimings).HasForeignKey(t => t.S_no);
        }
    }
}
