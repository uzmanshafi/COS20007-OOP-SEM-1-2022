using System;

namespace CaseStudyIteration1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //starting
            Console.WriteLine("\nSwin-Adventures : The Game\n\t");

            Console.WriteLine("Enter Player Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter {0}'s Description : ", name);
            string desc = Console.ReadLine();

            //creating the player
            Player player = new Player(name, desc);

            //creating the items
            Item sword = new Item(new string[] { "sword" }, "Iron Sword", "The Great Iron Sword");
            Item gem = new Item(new string[] { "gem" }, "Iron Ingots", "Rare Iron Ingot");

            //putting items into players inventory
            player.Inventory.Put(sword);
            player.Inventory.Put(gem);

            //creating a bag 
            Bag sBag = new Bag(new string[] { "small", "leather", "bag" }, "bag", "a small leather bag.");
            
            //putting a bag in players inventory
            player.Inventory.Put(sBag);

            //creating a new item and putting it in players bag
            Item portion = new Item(new string[] { "portion" }, "Heal Portion", "A small Heal Portion");
            sBag.Inventory.Put(portion);

            //paths & locations
            Location NorthCity = new Location(new string[] { "north city" }, "North City", "The North City District.");
            Paths NorthPath = new Paths(new string[] { "north" }, "road", "The North Road", NorthCity);
            player.Location = NorthCity;
            NorthCity.AddPath(NorthPath);

            //adding items to location
            Item food1 = new Item(new string[] { "small_mushroom" }, "Small Mushrooms", "a sussy small mushroom.");
            NorthCity.Inventory.Put(food1);
            Item food2 = new Item(new string[] { "big_mushroom" }, "Big Mushrooms", "a sussy big red mushroom.");
            NorthCity.Inventory.Put(food2);
            Item food3 = new Item(new string[] { "golden_apple" }, "Golden Apple", "a fallen shiny golden apple.");
            NorthCity.Inventory.Put(food3);

            string command = "";
            CommandProcessor cmd = new CommandProcessor();

            while(command != "exit")
            {
                Console.WriteLine("Please enter a command [Look command or Move command or exit]--> \n");
                command = Console.ReadLine();
                Console.WriteLine(cmd.Execute(player, command.Split(' ')));
            }

            Console.WriteLine("Disconnected " + player.Name + " from the game...");
        }
    }
}
