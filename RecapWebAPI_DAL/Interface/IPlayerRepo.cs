using RecapWebAPI_COMMON.Entities;

namespace RecapWebAPI_DAL.Interface
{
    public interface IPlayerRepo
    {
        List<Player> GetAll();
    }
}