using GymMnagment.DAL.Data.DbContexts;
using GymMnagment.DAL.Data.Models;
using GymMnagment.DAL.Repositorities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMnagment.DAL.Repositorities.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly GymDbContext _dbContetx;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(GymDbContext dbContext)
        {
            _dbContetx = dbContext;
            _dbSet = _dbContetx.Set<TEntity>();
        }
        public async Task<int> AddAsync(TEntity entity)
        {
           _dbSet.Add(entity);
            return await _dbContetx.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            return await _dbContetx.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
        {
           IQueryable<TEntity> query = tracking ? _dbSet : _dbSet.AsNoTracking();
            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id, CancellationToken ct = default)
        {
           return  await _dbSet.FindAsync(id, ct);
           
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            return await  _dbContetx.SaveChangesAsync();
        }
    }
}
