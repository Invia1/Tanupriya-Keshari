using System;
using System.Collections.Generic;
using FootBallTeamApp.Models;
using FootBallTeamApp.Entry_Point;
using FootBallTeamApp.BLL;
namespace FootBallTeamApp.Functionality
{
    public interface ITeamPlayersOperations
    {
        void AddPlayersName(Players pl);
        void RemovePlayersName(int ID);
        void UpdateList(int ID);
        void SearchData(int ID);
         List<Players> GetPlayersList();


    }
}
