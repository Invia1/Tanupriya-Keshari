using FootBallTeamApp.BLL;
using FootBallTeamApp.Functionality;
using FootBallTeamApp.Models;
using System;
using System.Collections.Generic;

namespace FootBallTeamApp.Entry_Point
{

    class MainApp
    {
        public static void Main()
        {


            PlayersActivities act = new PlayersActivities();
            int n;
            Console.WriteLine("\n\t\t\t\t\t|-----------------------------|");
            Console.WriteLine("\t\t\t\t\t|Welcome to Footaball Team App|");
            Console.WriteLine("\t\t\t\t\t|-----------------------------|");

            

            do
            {
            Label:

                Console.WriteLine("\nEnter 1 to Add players name  \n" +
                                  "Enter 2 to Remove players name  \n" +
                                  "Enter 3 to Update a player  \n" +
                                  "Enter 4 to search a player  \n" +
                                  "Enter 5 to show all the players details  \n" +
                                  "Enter 0 to exit");
                n=int.Parse(Console.ReadLine());
                if (n >= 0 && n <= 5)
                {
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("How many Players details you want to add");
                            int np= int.Parse(Console.ReadLine());

                           
                            for ( int i = 1; i<=np; i++)
                            {
                                var Obj = new Players();
                                if (np <= 12)
                                { 

                                    Console.WriteLine("Pls Enter Player Id");
                                    Obj.ID = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Pls Enter Player name");
                                    Obj.Name = Console.ReadLine();

                                    Console.WriteLine("Pls Enter Player Profile");
                                    Obj.Profile = Console.ReadLine();
                                    act.AddPlayersName(Obj);
                                }
                            }
                           
                            break;
                        case 2:
                            Console.WriteLine("please enter the employee id of which employee you want to remove:");
                            int PlayersID = Convert.ToInt32(Console.ReadLine());
                            act.RemovePlayersName(PlayersID);

                            break;
                        case 3:
                            Console.WriteLine("please enter the employee id of which employee you want to update:");
                            PlayersID = Convert.ToInt32(Console.ReadLine());
                            act.UpdateList(PlayersID);

                            break;

                        case 4:

                            Console.WriteLine("please enter the employee id of which employee you want to search:");
                            PlayersID = Convert.ToInt32(Console.ReadLine());
                            act.SearchData();


                            break;
                        case 5:
                            List<Players> objl = act.GetPlayersList();
                            
                            if (objl.Count > 0)
                            {
                                Console.WriteLine("------------data in your list---------");
                                foreach (var item in objl)
                                {
                                    Console.WriteLine($"Player's Name --------- {item.Name}\nPlayer's Id --------- {item.ID}\nPlayer's Profile ---------  {item.Profile}");
                               
                                }

                            }
                            else
                            { Console.WriteLine("OOps!!Your data list is empty"); }



                            break;


                        case 0:
                            Console.WriteLine("thank you");
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("please enter valid number:");
                    goto Label;
                }



            } while (n != 0);


        }
            
    }
}


    

