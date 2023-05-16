using System;
using System.Collections.Generic;

class Furniture
{
    List<string> items = new List<string>();
    
    public void Add(string name)
    {
        items.Add(name);
        
    }

    public void UpdateItems(string OldItem,string NewItem)
    {
            items.Remove(OldItem);
            items.Add(NewItem);
    }
    

    public void Remove(string name)
    {
        if(items.Contains(name))
            items.Remove(name);
        else
        {
            Console.WriteLine($" { name} is not in the list");
        }

    }

    public void Count()
    {
       Console.WriteLine("Total number of items is:"+items.Count);
    }

    public void ShowData()
    {
        foreach(var temp in items)
        {
            Console.WriteLine(temp);
        }
    }

    public void Search(string name )
    {
        if (items.Contains(name))
        {
            Console.WriteLine($"Yes{name}is present in the list");
        }
        else
        {
            Console.WriteLine($"No,it's not there in the list");
        }
    }


}

class FurnitureDetails
{
    public static void Main()
    {
        Furniture furniture = new Furniture();
        int n;
        do
        {
        Label:
            Console.WriteLine("\nEnter 1 to add items in the list.\n" +
                               "Enter 2 to update items in the list.\n" +
                               "Enter 3 to remove items in the list.\n" +
                               "Enter 4 to count items in the list.\n" +
                               "Enter 5 to show items in the list.\n" +
                               "Enter 6 to search items in the list.\n" +
                               "Enter 0 to come out of the loop.");
            n = int.Parse(Console.ReadLine());
            if (n >= 0 && n < 6)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("how many items do you want to add:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("please enter the name that you want to be store:");
                            string name = Console.ReadLine();
                            furniture.Add(name);

                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Old Name: ");
                        string oldName = Console.ReadLine();
                        furniture.Search(oldName);

                        Console.WriteLine("Enter New Name: ");
                        string newName = Console.ReadLine();
                        furniture.UpdateItems(oldName, newName);

                        break;

                    case 3:

                        Console.WriteLine("Enter the name u want to remove");
                        string removeName = Console.ReadLine();
                        furniture.Remove(removeName);

                        break;

                    case 4:

                        furniture.Count();

                        break;

                    case 5:

                        furniture.ShowData();

                        break;

                    case 6:
                        Console.WriteLine("Enter the name u want to search");
                        string rName = Console.ReadLine();
                        furniture.Search(rName);

                        break;

                    case 0:

                        Console.WriteLine("Thank you");

                        break;
                }
            }

            else
            {
                Console.WriteLine("Pls enter a valid number");
                goto Label;
            }

        } while (n != 0);
        
    }

}