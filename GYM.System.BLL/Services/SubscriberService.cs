using AutoMapper;
using GYM.System.BLL.Interfaces;
using GYM.System.BLL.Repositories;
using GYM.System.DAL.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.BLL.Services
{
	public class PlayerService : IPlayerService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public PlayerService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}
		public async Task<Player> AddSubscriberAsync(Player subscriber)
		{
			await _unitOfWork.Repository<Player>().AddAsync(subscriber);
			await _unitOfWork.Complete();
			return subscriber;
		}

		public async Task<bool> DeleteSubscriberAsync(int id)
		{
			var subscriber = await _unitOfWork.Repository<Player>().GetByIdAsync(id);
			if (subscriber is null)
			{
				return false;
			}
			_unitOfWork.Repository<Player>().Delete(subscriber);
			await _unitOfWork.Complete();
			return true;
		}

		public async Task<IEnumerable<Player>> GetAllSubscribersAsync()
		 => await _unitOfWork.Repository<Player>().GetAllAsync();

		public async Task<Player> GetSubscriberByIdAsync(int id)
		 =>  await _unitOfWork.Repository<Player>().GetByIdAsync(id);

		public async Task UpdateSubscriberAsync(Player subscriber)
		{
			_unitOfWork.Repository<Player>().Update(subscriber);
			await _unitOfWork.Complete();
		}
	}
}
