using GYM.System.DAL.Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.System.BLL.Interfaces
{
	public interface IPlayerService
	{
		Task<Player> AddSubscriberAsync(Player subscriber);
		Task<IEnumerable<Player>> GetAllSubscribersAsync();
		Task<Player> GetSubscriberByIdAsync(int id);
		Task UpdateSubscriberAsync(Player subscriber);
		Task<bool> DeleteSubscriberAsync(int id);
	}
}
