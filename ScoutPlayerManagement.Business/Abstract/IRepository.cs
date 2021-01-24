using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutPlayerManagement.Business
{
    public interface IRepository
    {
        void Add(Player player);

        List<Player> GetAllPlayers();
    }
}
