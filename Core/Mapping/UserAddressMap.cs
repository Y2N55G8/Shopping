using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class UserAddressMap:EntityTypeConfiguration<UserAddress>
    {
        public UserAddressMap()
        {
            //主键
            HasKey(x => x.UA_no);
            //收货地址
            Property(x => x.UA_name);
            //昵称
            Property(x => x.U_username);
            //联系人姓名
            Property(x => x.UA_person);
            //是否为默认地址
            Property(x => x.UA_main);
            //收货电话
            Property(x => x.UA_tel);
            //邮编
            Property(x => x.UA_emailno);
            ToTable("UserAddress");
        }
    }
}
