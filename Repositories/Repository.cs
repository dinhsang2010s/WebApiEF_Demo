using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using WEBAPIDemo.Interfaces;
using WEBAPIDemo.Models;

namespace WEBAPIDemo.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly MyDbContext context;
        internal DbSet<TEntity> dbSet;
        public Repository(MyDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public Task DeleteAsync(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetAsync(Guid entityId)
        {  
            return await dbSet.FindAsync(entityId);
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(string filter)
        {
            if (string.IsNullOrEmpty(filter))
            {
                return await dbSet.ToListAsync();
            }
            return await dbSet.Where(filter).ToListAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {   
            await dbSet.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
