using System;

/*Problema 3:
Cree una aplicación que ingrese kilómetros conducidos y litros usados, y calcule
kilómetros por litro..*/

namespace ManejoDeErrores
{
    class Program
    {
        //public const double MaxValue = 1.7976931348623157E+308;
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Ingrese la cantidad de kilometros");
                double kilometros=Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de litros");
                double litros=Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("El resultado del kilometosXLitros es "+KmXLitros(kilometros,litros));
                Console.WriteLine("PositiveInfinity: {0}", Double.IsPositiveInfinity(KmXLitros(kilometros,litros)));
                //Console.WriteLine("NegativeInfinity: {0}", Double.IsNegativeInfinity(result));
            }
            catch(FormatException exp){
                
                Console.WriteLine("Ingresó un valor inválido {0}. ",exp.Message);
            }
            
            
        }
        public static double KmXLitros(double km,double l ){
            return km/l;
        }
    }
}