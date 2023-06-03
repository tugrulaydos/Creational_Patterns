using Abstract_Factory.Client;
using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which Os Do you use?(Mac or Windows)");

            string Os = Console.ReadLine();

            Os = Os.ToLower();

            if (Os == "mac")
            {
                var factory = new WinFactory();
                Application app = new Application(factory);
            }
            else if (Os == "windoes")
            {
                var factory = new MacFactory();
                Application app = new Application(factory);
            }
            else
            {
                throw new Exception("Error! Unknown operating system");
            }         
                       

            
        }
    }
}