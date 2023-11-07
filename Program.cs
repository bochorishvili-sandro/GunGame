using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Numerics;


public class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(100);
        Opponent opponent = new Opponent(150);
        Gun gun = new Gun(10, 20);
        Dagger dagger = new Dagger(8, true);
        DualDagger dualDagger = new DualDagger(12);
       Bow bow = new Bow(15, 30);

        while (opponent.Hp > 0)
        {
            Console.WriteLine("Choose weapon:");
            Console.WriteLine("1) Gun");
            Console.WriteLine("2) Dagger");
            Console.WriteLine("3) Dual Dagger");
            Console.WriteLine("4) Bow");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        player.AttackWithWeapon(gun, opponent);
                        break;
                    case 2:
                        Console.Clear();
                        player.AttackWithWeapon(dagger, opponent);
                        break;
                    case 3:
                        Console.Clear();
                        player.AttackWithWeapon(dualDagger, opponent);
                        break;
                    case 4:
                        Console.Clear();
                        player.AttackWithWeapon(bow, opponent);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                 
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("Opponent defeated!");
    }
}