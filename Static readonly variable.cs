using System;
  
class FullName {
  
    public static readonly string name;
    public static readonly string surname;
   
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
