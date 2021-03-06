﻿using Core.Repository;
using Core.UnitofWork;
using Entities;
using EntityFramework.Extensions;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RoleGroupService : IRoleGroupService
    {
        IUnitofWork unit;
        IRepository<RoleGroup> RGroupRep;
        IRepository<RoleContact> contactRep;
        public RoleGroupService(IUnitofWork unit) {
            this.unit = unit;
            RGroupRep = unit.Repository<RoleGroup>();
            contactRep = unit.Repository<RoleContact>();
        }

        /// <summary>
        /// 查询所有用户权限管理组
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleGroup> GetRoleGroups()
        {
            return RGroupRep.Get();
        }
        /// <summary>
        /// 根据权限组id查询权限组
        /// </summary>
        /// <returns></returns>
        public RoleGroup GetRoleGroup(int RGid) {
            return RGroupRep.Get(x => x.RG_no == RGid,"",null).FirstOrDefault();
        }
        /// <summary>
        /// 新增管理员组
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int InsertGroup(string name,Array roles)
        {
            var RGroup= RGroupRep.Get(null, "", x => x.OrderByDescending(y => y.RG_no)).FirstOrDefault();
            int RGid = 1;
            if (RGroup != null) {
                RGid = RGroup.RG_no+1;
            }
            RGroupRep.Insert(new RoleGroup { RG_no = RGid, RG_name = name });
            foreach (var rid in roles)
            {
                contactRep.Insert(new RoleContact() { RG_no = RGid, R_no = Convert.ToInt32(rid) });
            }
            return unit.Commit();
        }
        /// <summary>
        /// 修改权限组信息
        /// </summary>
        /// <param name="RGid"></param>
        /// <param name="name"></param>
        /// <param name="roles"></param>
        /// <returns></returns>
        public int UpdateRoleGroup(int RGid, string name,Array rids)
        {
            try
            {
                //修改权限组信息
                RGroupRep.GetDbSet.Where(x => x.RG_no == RGid).Update(x => new RoleGroup()
                {
                    RG_name = name
                });
                Array oldRids = contactRep.Get(x=>x.RG_no == RGid,"",null).Select(x=>x.R_no).ToArray();
                //删除旧权限
                foreach (var old in oldRids)
                {
                    if (Array.IndexOf(rids,old) < 0) {
                        int iOid = Convert.ToInt32(old);
                        contactRep.GetDbSet.Where(x => x.RG_no == RGid && x.R_no == iOid).Delete();
                    }
                }
                //新增新权限
                foreach (var newId in rids)
                {
                    if (Array.IndexOf(oldRids,newId) < 0)
                    {
                        contactRep.Insert(new RoleContact()
                        {
                            RG_no = RGid,
                            R_no = Convert.ToInt32(newId)
                        });
                    }
                }
                unit.Commit();
                return 1;
            }
            catch (Exception ex) {
                return 0;
            }
        }
        /// <summary>
        /// 删除权限组
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public int DeleteGroupByGid(int gid)
        {
            try
            {
                RGroupRep.GetDbSet.Where(x => x.RG_no == gid).Delete();
                return 1;
            }
            catch (Exception) {
                return 0;
            }
        }
    }
}
