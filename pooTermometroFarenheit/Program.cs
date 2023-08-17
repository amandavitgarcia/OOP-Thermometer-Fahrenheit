using PooTermometro;

namespace PooTermometro
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuaPrograma = 1; 

            while(continuaPrograma == 1)
            {
                Console.WriteLine("\t \t \t \t ------ Conversão entre escalas termométricas ------");

                Console.WriteLine("\n\nEsse programa te auxiliará a converter as escalas: Celsius, Fahrenheit e Kelvin.\n");

                Menu menu = new Menu();
                menu.MostraMenu();

                Console.WriteLine("1 - Voltar ao menu \t2 - Encerrar programa");
                int respUsuario =Convert.ToInt32(Console.ReadLine());

                while (respUsuario < 1 || respUsuario > 2)
                {
                        Console.WriteLine("1 - Voltar ao menu \t2 - Encerrar programa");
                        respUsuario = Convert.ToInt32(Console.ReadLine());
                }

                while (respUsuario == 1)
                {
                    menu.MostraMenu();
                }

                continuaPrograma = 2; 
                
            }
            System.Environment.Exit(0);
            Console.WriteLine("Encerrando programa... ");
        }
    }
}
