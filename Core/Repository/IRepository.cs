using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    /// <summary>
    /// 通用仓储访问接口
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name=""></param>
        void Insert(T model);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        void Delete(T model);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        void Update(T model);
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();
        /// <summary>
        /// 通用查询
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get(Expression<Func<T,bool>> filter=null, string prop="", Func<IQueryable<T>,IOrderedQueryable<T>> orderby=null);


        DbSet<T> GetDbSet { get; }
    }
}
