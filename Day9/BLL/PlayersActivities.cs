using FootBallTeamApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallTeamApp.BLL
{
    class PlayersActivities
    {
        Players players = new Players();
        List<Players> obj = new List<Players>();

        public void AddPlayersName(Players pl)
        {
           obj.Add(pl);
        }
        
        public void RemovePlayersName(int ID)
        {
            for(int i = 0; i < obj.Count; i++)
            {
                if (ID == obj[i].ID)
                {
                    obj.RemoveAt(i);

                }

            }
            
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

        }
        public void SearchData()
        {

        }
        public List<Players> GetPlayersList()
        {
            return obj;
        }
    }
}

