using FootBallTeamApp.Functionality;
using FootBallTeamApp.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace FootBallTeamApp.BLL
{
    class PlayersActivities: ITeamPlayersOperations
    {
        Players players = new Players();
        List<Players> obj = new List<Players>();

        public object ID { get; private set; }
        public object Name { get; private set; }
        public object Profile { get; private set; }

        public void AddPlayersName(Players pl)
        {
           obj.Add(pl);
        }
        
        public void RemovePlayersName(int ID)
        {
            /*for(int i = 0; i < obj.Count; i++)
            {
                if (ID == obj[i].ID)
                {
                    obj.RemoveAt(i);

                }

            }*/
            var Remove = obj.Where(obj => obj.ID == ID).ToList();
            obj.RemoveAt(ID);


        }
        public void UpdateList(int ID)
        {
            Players players = new Players();
            for (int i = 0; i < obj.Count; i++)
            {
                if (ID == obj[i].ID)
                {
                    obj.RemoveAt(i);

                    Console.WriteLine("Enter new id");
                    players.ID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter new name");
                    players.Name = Console.ReadLine();

                    Console.WriteLine("Enter new Profile");
                    players.Profile = Console.ReadLine();

                    obj.Add(players);

                }

            }
            /*var Update = obj.Where(obj => obj.ID == ID).ToList();
            foreach (var p in Update)
            {
                obj.RemoveAt((int)p.ID);
                Console.WriteLine("Enter new id");
                players.ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter new name");
                players.Name = Console.ReadLine();

                Console.WriteLine("Enter new Profile");
                players.Profile = Console.ReadLine();

                obj.Add(players);
            }*/
        }
        public void SearchData(int id)
        {
            var Data = obj.Where(obj => obj.ID == id).ToList();

            if(Data.Count > 0)
            {
               
               foreach (var item in Data)
                {
                    Console.WriteLine(item.ID+" "+item.Name+" "+item.Profile);
                }
            }
        }
        public List<Players> GetPlayersList()
        {
            return obj;
        }
    }
}

