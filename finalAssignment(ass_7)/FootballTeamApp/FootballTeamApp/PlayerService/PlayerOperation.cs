using System;
using System.Collections.Generic;
using FootballTeamApp.functionality;
using FootballTeamApp.models;



namespace FootballTeamApp.PlayerService
{
      public class PlayerOperation:IPlayer
    {
        List<Player> FPlayer = new List<Player>();

        public int createPlayerData(Player p)
        {
            FPlayer.Add(p);
            return 1;
        }

        public List<Player> GetPlayerData()
        {
            return FPlayer;

        }

        public void DeleteData(int ID)
        {
            int a = 0;
            foreach (var i in FPlayer)
            {
                if(i.id==ID)
                {
                    FPlayer.Remove(i);
                    Console.WriteLine("1 record deleted");
                    a++;
                    break;
                    
                }
            }
            if(a==0)
            {
                Console.WriteLine("data not found");
            }
        }


        public void UpdateData(int ID) 
        {
            int a = 0;
            foreach (var i in FPlayer)
            {
                if (i.id == ID)
                {
                    
                    i.name = "sandeep";
                    i.skill = "Goalkeeper";
                    Console.WriteLine("1 record updates");
                    a++;
                    break;

                }
            }
            if (a == 0)
            {
                Console.WriteLine("record not exist");
            }

        }

        public void search(int ID)
        {
            int a = 0;
            foreach (var i in FPlayer)
            {
                if (i.id == ID)
                {
                   
                    Console.WriteLine("record found");
                    a++;
                    break;

                }
            }
            if (a == 0)
            {
                Console.WriteLine("record not found");
            }
        }

    }
}
