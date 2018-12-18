using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repository;
using Entities;

namespace Core.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        /// <summary>
        /// 上下文对象
        /// </summary>
        DbContext db;
        /// <summary>
        /// 上下文对象是否已被释放
        /// </summary>
        bool disposed = false;

        public UnitofWork(DbContext db) {
            this.db = db;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 释放上下文对象
        /// </summary>
        /// <param name="v"></param>
        private void Dispose(bool isDispose)
        {
            if (!disposed && isDispose) {
                //释放上下文对象
                db.Dispose();
            }
            //上下文对象释放了
            disposed = true;
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        public int Commit()
        {
            return db.SaveChanges();
        }

        /// <summary>
        /// 获取仓储对象
        /// 通过反射初始化所有仓储对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Repository<T> Repository<T>() where T : class
        {
            Dictionary<string, object> repositores = new Dictionary<string, object>();
            //首先通过缓存获取，当然这里是没有使用缓存的所以就打个注释
            //获取仓储对象
            string type = typeof(T).Name;
            //要是从缓存中获取不到仓储对象，就反射初始化仓储,这里没有缓存肯定默认为true咯
            if (true) {
                //获取仓储的类型
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)),db);
                repositores.Add(type, repositoryInstance);
            }
            return repositores[type] as Repository<T>;
        }
    }
}
