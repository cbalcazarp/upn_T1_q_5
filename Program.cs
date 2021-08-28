using System;

namespace upn_T1_q_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double gradosKelvin, gradosFahrenheit, gradosCelsius;
            Console.WriteLine("Conversión de grados Kelvin a grados Fahrenheit y Celsius");
            Console.Write("Ingrese grados Kelvin: ");
            gradosKelvin = Convert.ToDouble(Console.ReadLine());
            gradosFahrenheit = (gradosKelvin - 273.15) * 9/5 + 32;
            gradosCelsius = gradosKelvin - 273.15;
            Console.WriteLine("Lo ingresado en grados Fahrenheit es " + Convert.ToString(gradosFahrenheit) + " y en grados Celsius es " + Convert.ToString(gradosCelsius));


        }
    }
}
