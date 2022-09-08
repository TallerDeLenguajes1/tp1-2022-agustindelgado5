using System;

/*Problema 1:
Realizar una aplicación de consola que cargue de un número entero por teclado e
imprimir su cuadrado.*/

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Ingrese un número para obtener su cuadrado :)");
                int ResultadoCuadrado=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado del cuadrado es "+Cuadrado(ResultadoCuadrado));
            }
            catch(FormatException exp){
                
                Console.WriteLine("Ingresó un valor inválido {0}. ",exp.Message);
            }
         
            
        }
        public static int Cuadrado(int a){
            return a*a;
        }
    }
}