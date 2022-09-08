using System;

//Realizar una aplicación de consola que cargue 2 números y haga la división entre ellos.

namespace ManejoDeErrores
{
    class Program
    {
        static void Main(string[] args)
        {
              try
            {
            Console.WriteLine("Ingrese el numerador");
            int numero1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el denominador distinto que 0");
            int numero2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la división es "+División(numero1,numero2));

           /* if(numero2!=0){
                Console.WriteLine("El resultado de la división es "+División(numero1,numero2));
            }else{
                  Console.WriteLine("No se acepta la división por cero");
            }*/
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine("Error Encontrado{0} ",exp.Message);
               
            }
           

         
            // una forma de evitar también la division por cero es agregando este control
           /* if(numero2!=0){
                Console.WriteLine("El resultado de la división es "+División(numero1,numero2));
            }else{
                  Console.WriteLine("No se acepta la división por cero");
            }*/
            
           
           
           
            
        }
        public static int División(int a,int b){
           return a/b; 
            
        }
    }
}