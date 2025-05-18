using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football_Formation;
using static Football_Formation.Player.PositionType;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Player pl = new Player("John Doe", 25, 180, Player.PositionType.Defender, 100000);
            Console.WriteLine(pl);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
