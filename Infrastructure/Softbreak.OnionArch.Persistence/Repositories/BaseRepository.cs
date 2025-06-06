﻿using Microsoft.EntityFrameworkCore;
using Softbreak.OnionArch.CONTRACT.Repositories;
using Softbreak.OnionArch.DOMAIN.Entities.Abstracts;
using Softbreak.OnionArch.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Softbreak.OnionArch.Persistence.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().AnyAsync(exp);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(exp);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T originalEntity, T newEntity)
        {
            _context.Set<T>().Entry(originalEntity).CurrentValues.SetValues(newEntity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp);
        }
    }
}
