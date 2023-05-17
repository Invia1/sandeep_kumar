using FootballTeamApp.functionality;
using FootballTeamApp.models;
using FootballTeamApp.PlayerService;
using System;

namespace FootballTeamApp.UI
{
    public class main
    {
        public static void Main()
        {
            Player obj=new Player();
            obj.id = 1;
            obj.name = "Neymar";
            obj.skill = "defender";

            Player obj1 = new Player();
            obj1.id = 2;
            obj1.name = "ronaldo";
            obj1.skill = "centre forward";

            Player obj2 = new Player();
            obj2.id = 3;
            obj2.name = "messi";
            obj2.skill = "centre back";

            Player obj3 = new Player();
            obj3.id= 4;
            obj3.name = "richad";
            obj3.skill = "wing back";

            Player obj4= new Player();
            obj4.id = 5;
            obj4.name = "pele";
            obj4.skill = "defender";


            IPlayer po=new PlayerOperation();
            po.createPlayerData(obj);
            po.createPlayerData(obj1);
            po.createPlayerData(obj2);
            po.createPlayerData(obj3); 
            po.createPlayerData(obj4);

            Console.WriteLine("----------player data-------------------");
            List<Player> FPlayer = po.GetPlayerData();
            Console.WriteLine("JersyNo" + "   \t" + "player name" + "  \t" + "skill");
            foreach (var item in FPlayer)
            {
                Console.WriteLine(item.id + "\t \t" + item.name + "\t\t" + item.skill);
            }

            Console.WriteLine("\n\n");
            po.DeleteData(76);
            po.UpdateData(5);
            po.search(2);

            Console.WriteLine("\n\n");
            Console.WriteLine("----------player data after operation-------------------");
            Console.WriteLine("JersyNo" + "   \t" + "player name" + "  \t" + "skill");
            foreach (var item in FPlayer)
            {
                Console.WriteLine(item.id + "\t \t" + item.name + "\t\t" + item.skill);
            }





        }
    }
}
