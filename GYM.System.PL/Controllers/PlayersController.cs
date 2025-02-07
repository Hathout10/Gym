using AutoMapper;
using GYM.System.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYM.System.PL.Controllers
{
	public class PlayersController : BaseApiController
	{
		private readonly IPlayerService _playerService;
		private readonly IMapper _mapper;

		public PlayersController(IPlayerService playerService ,IMapper mapper)
        {
			_playerService = playerService;
			_mapper = mapper;
		}

    }
}
