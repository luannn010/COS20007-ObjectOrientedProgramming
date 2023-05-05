using System;

namespace SwinAdventure;


public class Mainclass
{
    static void Main(string[] args)
    {
        Player player;
        Bag bag;
        Item Infinity_Sword;
        Item Deathman_Plate;
        Item Hp_Portion;
        Command command;
        string input = "";

        Console.WriteLine("QUIT To Exit");
        Console.WriteLine();

        Console.WriteLine("~~~Wellcome to Neverland~~~");
        Console.WriteLine();
        Console.WriteLine("What is your name, my Lord?");
        string name = Console.ReadLine();
        Console.WriteLine($"My honor to see you {name}, What is your class?");
        string desc = Console.ReadLine();
        Console.WriteLine($"Hi {name},{desc}, Wellcome to the Guardian Village");
        // Assign player

        player = new Player(name, desc);
        // Assign bag

        bag = new Bag(new string[] { "bag" }, "Diamond Bag", "Storing items with 3000 slots");
        // Assign items

        Infinity_Sword = new Item(new string[] { "Sword" }, "Infinity Sword", "Infinity Sword - Powerfull Sword with flame power in every critical strike");
        Deathman_Plate = new Item(new string[] { "Plate" }, "Deathman Plate", "Deathman Plate - Brave like a Captian never surrender");
        Hp_Portion = new Item(new string[] { "Portion" }, "Hp Portion", "Hp Portion - Sweet drink can heal you 150 hp in 20 sec");

        // Assign command
        command = new LookCommand();

        // Put Items 
        player.Inventory.Put(Infinity_Sword);
        player.Inventory.Put(Deathman_Plate);
        player.Inventory.Put(bag);
        bag.Inventory.Put(Hp_Portion);

        while (input !="quit")
        {
            Console.Write("Command--> ");
            input = Console.ReadLine();
            if (input != "quit")
            {
                Console.WriteLine(command.Execute(player, input.Split()));

            }
        }
        Console.ReadLine();
    }
}
