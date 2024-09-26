using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");  
}
