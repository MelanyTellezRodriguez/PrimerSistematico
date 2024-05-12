using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerSistematico
{
    public partial class Automovil
    {
        public void PuedeConducir(int distancia)
        {


            Console.WriteLine("Ingrese la cantidad de gasolina en litros con los que cuenta para viajar:");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            double resultRendimiento = distancia / gasolina;

            double combustibleNecesario = distancia / resultRendimiento;

            if (NivelCombustible <= combustibleNecesario)
            {
                Console.WriteLine("¡NO PUEDE CONDUCIR EL AUTOMOVIL!");

            }
            else
            {
                Console.WriteLine("¡SI PUEDE CONDUCIR EL AUTOMOVIL!");
            }
            //return _nivelCombustible <= combustibleNecesario;



        }

        public void ReabastecerCombustible(double cantidad)
        {
            Console.WriteLine("Ingrese la capacidad maxima del tanque de combustible de su automovil:");
            double capacidadTanque = Convert.ToDouble(Console.ReadLine());



            if (NivelCombustible + cantidad >= capacidadTanque)
            {
                Console.WriteLine("¡Tanque lleno!, no se puede reabastecer mas combustible");



            }
            else
            {
                Console.WriteLine("si se puede reabastecer mas combustible");
                NivelCombustible += cantidad;

            }





        }

        public void Conducir(int distancia)
        {

            Console.WriteLine("Ingrese la distancia en kilometros que está recorriendo el utomovil:");
            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de gasolina en litros con los que cuenta para viajar:");
            double gasolina = Convert.ToDouble(Console.ReadLine());

            double resultRendimiento = distancia / gasolina;

            double combustibleNecesario = distancia / resultRendimiento;

            if (combustibleNecesario >= NivelCombustible)
            {
                Console.WriteLine("No hay sificiente combustible para que emprenda el viaje");

            }
            else
            {
                Console.WriteLine($"¡Está conduciendo! ");
                NivelCombustible -= combustibleNecesario;

                Console.WriteLine("El nivel actual de combustible es" + "" + NivelCombustible);
            }




        }
    }
}
