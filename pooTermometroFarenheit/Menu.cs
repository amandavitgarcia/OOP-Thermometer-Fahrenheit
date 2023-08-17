using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTermometro
{
    public class Menu
    {
        // Construtor 
        public Menu()
        {
            EscalaCelsius = 0;
            EscalaFahrenheit = 0;
            EscalaKelvin = 0;
        }

        // Propriedades 
        int EscalaCelsius { get; set; }
        int EscalaFahrenheit { get; set; }
        public int EscalaKelvin { get; set; }


        // Método
        public void MostraMenu()
        {
            string traco = new string('-', 80);
            Console.WriteLine(traco);

            Console.WriteLine("Qual o conversor desejado? ");
            Console.WriteLine("1 - Celsius em Fahrenheit");
            Console.WriteLine("2 - Celsius em Kelvin");
            Console.WriteLine("3 - Fahrenheit em Kelvin");
            Console.WriteLine("4 - Fahrenheit em Celsius");
            Console.WriteLine("5 - Kelvin em Celsius");
            Console.WriteLine("6 - Kelvin em Fahrenheit");
            Console.WriteLine("0 - Sair \n");

            // Armazenando a resposta do usuário 
            short option = short.Parse(Console.ReadLine());

            Console.WriteLine(traco);

            // Criando uma instância da classe ConversorDeTemperatura
            ConversorDeTemperatura conversor = new ConversorDeTemperatura();

            //usando switch pra chamar as funções que temos
            switch (option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    conversor.ConverteCelsiusEmFahrenheit(EscalaCelsius);
                    break;
                case 2:
                    conversor.ConverteCelsiusEmKelvin(EscalaCelsius);
                    break;
                case 3:
                    conversor.ConverteFahrenheitEmKelvin(EscalaFahrenheit);
                    break;
                case 4:
                    conversor.ConverteFahrenheitEmCelsius(EscalaFahrenheit);
                    break;
                case 5:
                    conversor.ConverteKelvinEmCelsius(EscalaKelvin);
                    break;
                case 6:
                    conversor.ConverteKelvinEmFahrenheit(EscalaKelvin);
                    break;
                default:
                    MostraMenu();
                    break;
            }

        }
    }
    
}
