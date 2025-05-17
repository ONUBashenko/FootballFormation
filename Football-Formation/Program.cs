using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football_Formation;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Player pl = new Player("John Doe", 25, 180, 100000);
            Console.WriteLine(pl);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
