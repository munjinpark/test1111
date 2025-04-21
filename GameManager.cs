using System.Reflection.Emit;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class GameManager
    {
        public static void ErrorMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {


            Menu menu = new Menu();
            menu.DisplayMenu(); 
        }
    }
}
