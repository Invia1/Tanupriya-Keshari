using System;
  
class FullName {
  
    public readonly string name;
    public readonly string surname;
  
    public readonly string nickName = "Manu";
  
   
    public FullName(string a, string b)
    {
  
        name = a;
        surname = b;
        Console.WriteLine("Display value of Name :- {0} "
                          + "Surname :- {1}", name, surname);
    }
  

    static public void Main()
    {
        FullName ob = new FullName("Tanupriya", "Keshari");
    }
}