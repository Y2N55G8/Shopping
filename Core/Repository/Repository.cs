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
    /// EF版通用仓储查询
    /// </summary>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// 上下文对象
        /// </summary>
        IocDBContext db;
        /// <summary>
        /// 表对象
        /// </summary>
        DbSet<T> dbSet;

        public Repository(IocDBContext db){
            this.db = db;
            this.dbSet = db.Set<T>();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        public void Insert(T model)
        {
            dbSet.Add(model);
        }
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="id"></param>
        public void Delete(object id) {
            T t = dbSet.Find(id);
            dbSet.Remove(t);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        public void Delete(T model)
        {
            if (db.Entry(model).State == EntityState.Detached) {
                dbSet.Attach(model);
            }
            dbSet.Remove(model);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        public void Update(T model)
        {
            dbSet.Attach(model);
            db.Entry(model).State = EntityState.Modified;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Get()
        {
            return dbSet.ToList();
        }
        /// <summary>
        /// 通用查询
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderby"></param>
        /// <param name="prop"></param>
        /// <returns></returns>
        public IEnumerable<T> Get(Expression<Func<T, bool>> filter, string prop, Func<IQueryable<T>, IOrderedQueryable<T>> orderby)
        {
            IQueryable<T> query = dbSet;
            //条件查询
            if (filter != null) {
                query = query.Where(filter);
            }
            //多表查询
            foreach (var i in prop.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(i);
            }
            //排序
            if (orderby != null) {
                query = orderby(query);
            }
            return query.ToList();
        }

        public DbSet<T> GetDbSet
        {
            get { return this.dbSet; }
        }
    }
}
