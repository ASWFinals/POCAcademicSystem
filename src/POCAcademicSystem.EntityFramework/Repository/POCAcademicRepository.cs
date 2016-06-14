using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Takenet.Library.Data.EntityFramework;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Repository
{
    public abstract class POCAcademicRepository<TEntity, TK> : EntityRepository<TEntity, TK> where TEntity : class
    {
        protected POCAcademicRepository(DbContext context)
            : base(context)
        {
        }

        public new virtual IQueryable<TEntity> AsQueryable()
        {
            return base.AsQueryable();
        }

        public new virtual TEntity GetById(TK id)
        {
            var entity = base.GetById(id);
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        public new virtual void Add(TEntity entity, bool isNew)
        {
           
            base.Add(entity, isNew);
        }

        public new virtual void Remove(TEntity entity)
        {
            Add(entity, false);
        }
    }
}
