using CountryA;
using CountryB;
using CountryC;
namespace CapitalPopulationApp
{
    class Program
    {
        static void Main()
        {
            CapitalA capitalA = new CapitalA();
            CapitalB capitalB = new CapitalB();
            CapitalC capitalC = new CapitalC();

            Console.WriteLine($"Population of {capitalA.Name} is {capitalA.Population}");
            Console.WriteLine($"Population of {capitalB.Name} is {capitalB.Population}");
            Console.WriteLine($"Population of {capitalC.Name} is {capitalC.Population}");

            if (capitalA.Population > capitalB.Population && capitalA.Population > capitalC.Population)
            {
                Console.WriteLine($"{capitalA.Name} has the largest population.");
            }
            else if (capitalB.Population > capitalA.Population && capitalB.Population > capitalC.Population)
            {
                Console.WriteLine($"{capitalB.Name} has the largest population.");
            }
            else if (capitalC.Population > capitalA.Population && capitalC.Population > capitalB.Population)
            {
                Console.WriteLine($"{capitalC.Name} has the largest population.");
            }
            else
            {
                Console.WriteLine("Population is equal between capitals.");
            }
        }
    }
}
