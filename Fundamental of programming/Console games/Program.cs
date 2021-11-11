using System;
using System.Linq;
using System.Threading;
namespace Console_games
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"                (             )     *                      )   
 (  (           )\ )   (   ( /(   (  `           *   )  ( /(   
 )\))(   ' (   (()/(   )\  )\())  )\))(   (    ` )  /(  )\())  
((_)()\ )  )\   /(_))(((_)((_)\  ((_)()\  )\    ( )(_))((_)\   
_(())\_)()((_) (_))  )\___  ((_) (_()((_)((_)  (_(_())   ((_)  
\ \((_)/ /| __|| |  ((/ __|/ _ \ |  \/  || __| |_   _|  / _ \  
 \ \/\/ / | _| | |__ | (__| (_) || |\/| || _|    | |   | (_) | 
  \_/\_/  |___||____| \___|\___/ |_|  |_||___|   |_|    \___/  
                                                               "); //says welcome
            Thread.Sleep(1400);
            Console.WriteLine(@"╔╦╗╦╔═╗  ╔╦╗╔═╗╔═╗  ╔╦╗╔═╗╔═╗
 ║ ║║     ║ ╠═╣║     ║ ║ ║║╣ 
 ╩ ╩╚═╝   ╩ ╩ ╩╚═╝   ╩ ╚═╝╚═╝"); //says tictactoe
            
                int num = -1;
                string[,] array = new string[3, 3] {
                {"[]","[]","[]"},
                {"[]","[]","[]"},
                {"[]","[]","[]"} };
            for (int n = 0; n < 9; n++)
            {
                bool loop = false;
                bool loop1 = false;
                int Player1R = 0;
                int Player1C = 0;
                int Player2R = 0;
                int Player2C = 0;
                while (!loop)
                {
                    Console.WriteLine("Player one choose a row between 1-3");
                    Player1R = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Player one choose a column between 1-3");
                    Player1C = Convert.ToInt32(Console.ReadLine());
                    if (Player1C > 3 || Player1R > 3)
                    {
                        Console.WriteLine("Error Please enter a value between 1-3");
                    }
                    else
                    {
                        loop = true;
                    }
                }
                bool loop3 = false;
                while (!loop3)
                {
                    if (array[Player1C - 1, Player1R - 1] == "X")
                    {
                        Console.WriteLine("Error please try again");
                    }
                    else if (array[Player1C - 1, Player1R - 1] == "O")
                    {
                        Console.WriteLine("Error please try again");
                    }
                    else
                    {
                        array[Player2C - 1, Player2R - 1] = "O";
                        break;
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                while (!loop1)
                {
                    Console.WriteLine("Player two choose a row between 1-3");
                    Player2R = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Player two choose a column between 1-3");
                    Player2C = Convert.ToInt32(Console.ReadLine());
                    if (Player2C > 3 || Player2R > 3)
                    {
                        Console.WriteLine("Error Please enter a value between 1-3");
                    }
                    else
                    {
                        loop1 = true;
                    }
                }
                bool loop2 = false;
                while (!loop2)
                {
                    if (array[Player2C - 1, Player2R - 1] == "X")
                    {
                        Console.WriteLine("Error please try again");
                    }
                    else if (array[Player2C - 1, Player2R - 1] == "O")
                    {
                        Console.WriteLine("Error please try again");
                    }
                    else
                    {
                        array[Player2C - 1, Player2R - 1] = "O";
                        loop2 = true;
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
