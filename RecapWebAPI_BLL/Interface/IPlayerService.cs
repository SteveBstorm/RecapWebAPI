using RecapWebAPI_COMMON.Entities;

namespace RecapWebAPI_BLL.Interface
{
    public interface IPlayerService
    {
        List<Player> GetAll();
    }
}