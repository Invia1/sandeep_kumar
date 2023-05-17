using FootballTeamApp.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamApp.functionality
{
    public interface IPlayer
    {
        int createPlayerData(Player p);
         List<Player> GetPlayerData();
        void DeleteData(int ID);
        void search(int ID);
        void UpdateData(int ID);
        

    }
}
