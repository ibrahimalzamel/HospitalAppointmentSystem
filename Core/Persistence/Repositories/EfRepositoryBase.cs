﻿using Core.Domain;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories
{
    public class EfRepositoryBase<TEntity, TId, TContext> : IAsyncRepository<TEntity, TId>, IRepository<TEntity, TId>
       where TEntity : Entity<TId>, new()
       where TContext : DbContext
    {
        protected readonly TContext Context;

        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> Query() => Context.Set<TEntity>();

        public async Task<TEntity> AddAsync(TEntity entity, params Expression<Func<TEntity, object>>[]? includes)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

            var entry = Context.Entry(entity);
            var navigationProperties = entry.Metadata.GetNavigations();

            foreach (var navigation in navigationProperties)
            {
                if (!navigation.IsCollection)
                {
                    await entry.Reference(navigation.Name).LoadAsync();
                }
                else
                {
                    await entry.Collection(navigation.Name).LoadAsync();
                }
            }
            return entry.Entity;
        }

        public async Task<IList<TEntity>> AddRangeAsync(IList<TEntity> entities)
        {
            await Context.AddRangeAsync(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IList<TEntity>> UpdateRangeAsync(IList<TEntity> entities)
        {
            Context.UpdateRange(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IList<TEntity>> DeleteRangeAsync(IList<TEntity> entities)
        {
            Context.RemoveRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public async Task<IPaginate<TEntity>> GetListAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int index = 1,
            int size = 10,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        )
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                queryable = orderBy(queryable);
            return Paginate<TEntity>.Create(queryable, pageIndex: index, pageSize: size);
        }

        public async Task<TEntity?> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        )
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            return await queryable.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default
        )
        {
            IQueryable<TEntity> queryable = Query();
            if (predicate is not null)
                queryable = queryable.Where(predicate);
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            return await queryable.AnyAsync(cancellationToken);
        }

        public TEntity Add(TEntity entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public IList<TEntity> AddRange(IList<TEntity> entities)
        {
            Context.AddRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public TEntity Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
            return entity;
        }

        public IList<TEntity> UpdateRange(IList<TEntity> entities)
        {
            Context.UpdateRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public TEntity Delete(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
            return entity;
        }

        public IList<TEntity> DeleteRange(IList<TEntity> entities)
        {
            Context.RemoveRange(entities);
            Context.SaveChanges();
            return entities;
        }

        public TEntity? Get(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool enableTracking = true
        )
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            return queryable.FirstOrDefault(predicate);
        }

        public IPaginate<TEntity> GetList(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int index = 1,
            int size = 10,
            bool enableTracking = true
        )
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                queryable = orderBy(queryable);
            return Paginate<TEntity>.Create(queryable, pageIndex: index, pageSize: size);
        }


        public bool Any(Expression<Func<TEntity, bool>>? predicate = null, bool enableTracking = true)
        {
            IQueryable<TEntity> queryable = Query();
            if (predicate is not null)
                queryable = queryable.Where(predicate);
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            return queryable.Any();
        }

        public async Task<IQueryable<TEntity>> GetListNotPagedAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include != null)
                queryable = include(queryable);
            if (predicate != null)
                queryable = queryable.Where(predicate);
            if (orderBy != null)
                queryable = orderBy(queryable);
            return queryable;
        }
    }
}
