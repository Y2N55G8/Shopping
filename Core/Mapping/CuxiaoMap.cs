using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace Core.Mapping
{
    public class CuxiaoMap : EntityTypeConfiguration<Cuxiao>
    {
        //促销
        public CuxiaoMap() {
            //主键
            HasKey(x => x.C_no);
            //活动名称
            Property(x => x.C_name);
            //促销的商品
            Property(x => x.C_no).IsRequired();
            //开始时间
            Property(x => x.C_starttime);
            //结束时间
            Property(x => x.C_endtime);
            //最低用户类型
            Property(x => x.UT_no);
            //匹配上限
            Property(x => x.C_max);
            //活动状态(1启用 2停止)
            Property(x => x.C_flag);

            //数据库名称
            ToTable("Cuxiao");
        }
    }
}
