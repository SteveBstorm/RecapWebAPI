using RecapWebAPI_BLL.Interface;
using RecapWebAPI_COMMON.Entities;
using RecapWebAPI_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapWebAPI_BLL.Services
{
    public class PlayerService : IPlayerService
    {
        public readonly IPlayerRepo _playerRepo;
        public PlayerService(IPlayerRepo playerRepo)
        {
            _playerRepo = playerRepo;
        }

        public List<Player> GetAll()
        {
            return _playerRepo.GetAll();
        }
    }
}
