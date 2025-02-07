using GYM.System.BLL.Interfaces;
using GYM.System.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.BLL.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly GymDbContext _context;
		private Hashtable _repostories;
		public UnitOfWork(GymDbContext context)
        {
			_context = context;
		}
        public async Task<int> Complete()
		{
			return await _context.SaveChangesAsync();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
		{
			if (_repostories == null)
				_repostories = new Hashtable();
			var type = typeof(TEntity).Name;

			if (!_repostories.ContainsKey(type))
			{
				var repository = new GenericRepository<TEntity>(_context);
				_repostories.Add(type, repository);
			}
			return (IGenericRepository<TEntity>)_repostories[type];
		}
	}
}
