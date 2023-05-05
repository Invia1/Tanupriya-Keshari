using System;  
                      
public class DuplicateCharacters  
{  
    public static void Main()  
    {  Console.Write("Enter the string : ");
            String str = Console.ReadLine();  
        int count;  
          
        
        char[] dup = str.ToCharArray();  
          
        Console.WriteLine("Duplicate characters in a given string: ");  
        
        for(int i = 0; i <dup.Length; i++) {  
            count = 1;  
            for(int j = i+1; j <dup.Length; j++) {  
                if(dup[i] == dup[j] && dup[i] != ' ') {  
                    count++;  
                   
                    dup[j] = '0';  
                }  
            }  
            
            if(count > 1 && dup[i] != '0')  
                Console.WriteLine("{0} - {1}",dup[i],count);  
        }  
    }  
}