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

        string [,]  array = new string[,]
        {
            {"blank", "blank" },
        }
    }
}
