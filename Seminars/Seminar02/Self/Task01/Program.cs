using System;
using System.Runtime.Intrinsics.Arm;
class Program{
    static void Main(string[] args)
    {
        int a; double b;char c;
        Console.Write("Введите int: ");
        if (int.TryParse(Console.ReadLine(),out a)) Console.WriteLine("Переменная типа int");
        else Console.WriteLine("Переменная не типа int");
        Console.Write("Введите double: ");
        if (double.TryParse(Console.ReadLine(),out b)) Console.WriteLine("Переменная типа double");
        else Console.WriteLine("Переменная не типа double");
        Console.Write("Введите char: ");
        if (char.TryParse(Console.ReadLine(),out c)) Console.WriteLine("Переменная типа char");
        else Console.WriteLine("Переменная не типа char");

        
    }
}