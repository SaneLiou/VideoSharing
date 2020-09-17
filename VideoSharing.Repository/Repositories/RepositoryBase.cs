using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using VideoSharing.Data.Context;
using VideoSharing.Repository.Interfaces;

namespace VideoSharing.Repository.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected VideoSharingContext VideoSharingContext { get; set; }
        public RepositoryBase(VideoSharingContext videoSharingContext)
        {
            this.VideoSharingContext = videoSharingContext;
        }
        public void Create(T entity)
        {
            this.VideoSharingContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.VideoSharingContext.Set<T>().Remove(entity);

        }

        public IQueryable<T> FindAll()
        {
            return this.VideoSharingContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.VideoSharingContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this.VideoSharingContext.Set<T>().Update(entity);

        }
    }
}
