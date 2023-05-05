using System;

class Palindrome
{
    public static void Main()
    {
    string str,rev="",n="";
    Console.Write("Enter the string : ");
    str=Console.ReadLine();
    n=str;
    for(int i=str.Length-1;i>=0;i--)
    {
        rev+=str[i];
    }
    if(n==rev)
    Console.Write("Palindrome");
    else
        Console.Write("NOt a Palindrome");
    
    }


}