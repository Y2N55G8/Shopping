using Core.Repository;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitofWork
{
    /// <summary>
    /// 工作单元模式接口
    /// </summary>
    public interface IUnitofWork : IDisposable
    {
        /// <summary>
        /// 动态仓储
        /// </summary>
        /// <typeparam name="T">业务模型对象</typeparam>
        /// <returns>当前业务模型对象的仓储对象</returns>
        Repository<T> Repository<T>() where T : class;
        /// <summary>
        /// 事务提交
        /// </summary>
        /// <returns></returns>
        int Commit();
    }
}
