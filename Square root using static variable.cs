using System;
public class MyMath
{
      public static int sqrt(int n){return n*n;}
}
class TestMyMath
{
    public static void Main()
{
    Console.WriteLine("Square root of 3 is : "+ MyMath.sqrt(3));
}
}