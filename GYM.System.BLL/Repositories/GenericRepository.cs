using GYM.System.BLL.Interfaces;
using GYM.System.DAL.Data.Contexts;
using GYM.System.DAL.Data.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.BLL.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly GymDbContext _context;


		public GenericRepository( GymDbContext context)
        {
			_context = context;

		}

		public async Task AddAsync(T entity)
		  => await _context.Set<T>().AddAsync(entity);

		public void Delete(T entity)
		  => _context.Set<T>().Remove(entity);

		public async Task<IReadOnlyList<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
			 => await _context.Set<T>().FindAsync(id);

		public void Update(T entity)
		 => _context.Set<T>().Update(entity);
	}
}
