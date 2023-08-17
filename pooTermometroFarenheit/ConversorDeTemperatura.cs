using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooTermometro
{
    public class ConversorDeTemperatura
    {
        public ConversorDeTemperatura()
        {
            TemperaturaFarenheit = 0;
            TemperaturaCelsius = 0;
            TemperaturaKelvin = 0; 
        }

        public double TemperaturaFarenheit { get; set; }

        public double TemperaturaCelsius { get; set; }

        public double TemperaturaKelvin { get; set; }

        // Métodos 

        // Celsius em Fahrenheit - 001
        public void ConverteCelsiusEmFahrenheit(int tempCelsius)
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            tempCelsius = Convert.ToInt32(Console.ReadLine());

            double fahrenheit = (tempCelsius * 9 / 5) + 32;
            Console.WriteLine($"\n{tempCelsius}°C em Fahrenheit equivale a aproximadamente {fahrenheit.ToString("0.00")}°F.");
        }

        // Celsius em Kelvin - 002
        public void ConverteCelsiusEmKelvin(int tempCelsius)
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            tempCelsius = Convert.ToInt32(Console.ReadLine());

            double kelvin = tempCelsius + 273.15;
            Console.WriteLine($"\n{tempCelsius}°C em Kelvin equivale a aproximadamente {kelvin.ToString("0.00")}K.");
        }


        // Fahrenheit em Kelvin - 003
        public void ConverteFahrenheitEmKelvin(int tempFahrenheit)
        {
            Console.Write("Informe a temperatura em Fahrenheit: ");
            tempFahrenheit = Convert.ToInt32(Console.ReadLine());
            double temperaturaKelvin = (tempFahrenheit + 459.67) * 5 / 9;
            Console.WriteLine($"\n{tempFahrenheit}ºF em Kelvin equivale a aproximadamente {temperaturaKelvin.ToString("0.00")}K.");
        }

        // Fahrenheit em Celsius - 004
        public void ConverteFahrenheitEmCelsius(int tempFahrenheit)
        {
            Console.Write("Informe a temperatura em graus Fahrenheit: ");
            tempFahrenheit = Convert.ToInt32(Console.ReadLine());

            double temperaturaCelsius = (5 * (tempFahrenheit - 32) / 9);
            Console.WriteLine($"\n{tempFahrenheit}°F em Celsius equivale a aproximadamente {temperaturaCelsius.ToString("0.00")}ºC.");
        }

        // Kelvin em Celsius - 005
        public void ConverteKelvinEmCelsius(int tempKelvin)
        {
            Console.Write("Informe a temperatura em Kelvin: ");
            tempKelvin = Convert.ToInt32(Console.ReadLine());

            double celsius = tempKelvin - 273.15;
            Console.WriteLine($"\n{tempKelvin}K em Celsius equivale a aproximadamente {celsius.ToString("0.00")}°C.");
        }

        // Kelvin em Fahrenheit - 006
        public void ConverteKelvinEmFahrenheit(int tempKelvin)
        {
            Console.Write("Informe a temperatura em Kelvin: ");
            tempKelvin = Convert.ToInt32(Console.ReadLine());

            double fahrenheit = (tempKelvin - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"{tempKelvin}K em Fahrenheit equivale a aproximadamente {fahrenheit.ToString("0.00")}°F.");
        }
    }
}

