using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutPlayerManagement.Business.Concrete
{
    public class SQLRepo : IRepository
    {
        private ScoutDBEntities _data;
        public SQLRepo()
        {
            _data = new ScoutDBEntities();
        }
        public void Add(Player player)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetAllPlayers()
        {
            return _data.Players.ToList();
        }
    }
}
