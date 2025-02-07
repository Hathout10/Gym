﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.BLL.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IReadOnlyList<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task AddAsync(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
