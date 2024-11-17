using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static string[] poke = { "Pikachu", "Bulbasaur", "Charmander", "Squirtle", "Jigglypuff", "Meowth", "Psyduck", "Machop", "Gengar", "Eevee", "Snorlax", "Chikorita", "Cyndaquil", "Totodile", "Togepi", "Mareep", "Umbreon", "Espeon", "Miltank", "Blissey" };

    static Random rand = new Random();
    static string[] Ash = poke.OrderBy(x => rand.Next()).Take(5).ToArray();
    static string[] Gary = poke.Except(Ash).OrderBy(x => rand.Next()).Take(5).ToArray();
    static void Main()
    {
        menu();
    }

    static void menu(){
        int menuOption;

        do {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("|        MENU        |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|    1. Show Teams   |");
            Console.WriteLine("----------------------");
            Console.WriteLine("|    0. Salir        |");
            Console.WriteLine("----------------------");
            Console.Write("Selecciona al opcion a seguir:");
            menuOption = GetUserOption();
            if (menuOption == 2){
                Console.WriteLine("Inserta una cantidad numerica valida.");
            } else if(menuOption == 1){
                Console.Clear();
                showteams();
            }
        }while (menuOption!=0);
    }

    static int GetUserOption(){
        try{
            int userOption = Convert.ToInt32(Console.ReadLine());
            if(userOption >= 0 && userOption <= 1){
                return userOption;
            }

            return 2;
        } catch (Exception){
            return 2;
        }
    }
    static void showteams()
    {
        int option;
        Console.WriteLine("\n----------------------");
        Console.WriteLine("|        TEAMS       |");
        Console.WriteLine("----------------------");
        Console.WriteLine("|    1. Gary         |");
        Console.WriteLine("----------------------");
        Console.WriteLine("|    0. Ash          |");
        Console.WriteLine("----------------------");
        Console.Write("Selecciona al opcion a seguir:");
        option = Convert.ToInt32(Console.ReadLine());
        if(option == 0){
            Console.WriteLine("\nAsh's random Pokemons:");
            for (int i = 0; i < Ash.Length; i++)
            {
                Console.WriteLine(Ash[i]);
            }
        }else{
            Console.WriteLine("\nGary's random Pokemons:");
            for (int i = 0; i < Gary.Length; i++)
            {
                Console.WriteLine(Gary[i]);
            }
        }
    }
}
