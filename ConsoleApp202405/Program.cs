namespace ConsoleApp202405
{
    /*
     * Namespace
     * Metoder i andre klasser
     * Class
     * GitHub
     * Resharper
     * Top-level statements
     * De viktigste datatypene
     * var
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            var name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");
        }
    }

    class OtherClass
    {

    }
}

