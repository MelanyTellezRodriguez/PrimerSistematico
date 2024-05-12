using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerSistematico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Atributos

            string marca, placa, modelo, color;
            double capacidadTanque;
            int distancia;
            double cantidad;

            Console.WriteLine("**SIMULACION DE UNA GESTION AUTOMOTRIZ**");
            Console.WriteLine("Ingrese la marca del automovil:");
            marca = Console.ReadLine();
            Console.WriteLine("Ingrese la placa del automovil:");
            placa = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del automovil:");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingrese el color del automovil:");
            color = Console.ReadLine();
            Console.WriteLine("Ingrese la capacidad del tanque de combustible de su automovil:");
            capacidadTanque = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Automovil auto = new Automovil(marca, placa, modelo, color, capacidadTanque);


            Console.WriteLine("Ingrese la distancia en kilometros que recorrerá el automovil:");
            distancia = Convert.ToInt32(Console.ReadLine());


            auto.PuedeConducir(distancia);

            Console.WriteLine("Ingrese la cantidad de gasolina con la que quiere rellenar el tanque:");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            auto.ReabastecerCombustible(cantidad);

            Console.WriteLine();
            auto.Conducir(distancia);







        }
    
    }
}
