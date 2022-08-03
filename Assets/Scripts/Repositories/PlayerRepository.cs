using Common.Repositories;
using World.Unit;

namespace Repositories
{
    public class PlayerRepository : BaseRepository<World.Unit.Player>
    {
        private World.Unit.Player _currentPlayer;
        
        public new void AddItem(World.Unit.Player item)
        {
            //TODO:2022-04-28 17:11:40 implement repository on adding multiplayer
            _currentPlayer = item;
        }

        public World.Unit.Player GetPlayer()
        {
            return _currentPlayer;
        }
    }
}