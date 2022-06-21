using DOTNET_POO.src.Entities;
using System; 
namespace dotnet_poo

{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Arus = new Hero("Arus", 42, "Knight", 749, 72);
            Hero Wedge = new Hero("Wedge", 42, "Ninja", 574, 89);
            Wizard Jenica = new Wizard("Jenica", 42, "White Wizard", 601, 482);
            Wizard Topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641); 

            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jenica.Attack()); 
            Console.WriteLine(Jenica.Attack(10)); 

        }
    }
}
