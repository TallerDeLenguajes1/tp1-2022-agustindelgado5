using System;
using System.Collections.Generic;

namespace TP1DelgadoCarlosAgustinTaller2_2022
{
   /// public enum Estado { casado = 0, divorciado = 1, titulo = 3 };
    class Program
    {
        static void Main(string[] args)
        {
            /*c) Permite el ingreso de N trabajadores
            d) Muestra en una lista los datos: Apellido y Nombre, Edad, Antigüedad y Salario de los
            trabajadores ingresados.*/
            Console.WriteLine("Ingresar N empleados");
            int N = Convert.ToInt32(Console.ReadLine());

            Empleado[] Emp = new Empleado[N];//defino un arreglo de N empleados

            List<Empleado> empleados = new List<Empleado>();

            for (int i = 0; i <N ; i++)
            {
                try
                {
                    Console.WriteLine("nombre del empleado", +i);
                    string nombre = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("apellido del empleado", +i);
                    string apellido = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("direccion del empleado", +i);
                    string direccion = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("fecha ingreso del empleado", +i);
                    DateTime FechaIngreso = Convert.ToDateTime(Console.ReadLine());


                    Console.WriteLine("puesto del empleado", +i);
                    string puesto = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("sueldo del empleado", +i);
                    float sueldo = float.Parse(Console.ReadLine());

                    Console.WriteLine("estado del empleado", +i);

                    //Estado estado = Estado.casado;
                    Emp[i] = new Empleado(nombre, apellido, direccion, FechaIngreso, puesto, sueldo);//guardo mis datos dentro de mi arreglo
                    empleados.Add(Emp[i]);
                }
                /*
                catch (StackOverflowException  ex)
                {


                    Console.WriteLine("Error no se pudo cargar los datos tipo enum ,valor fuera del rango permitido " + ex.Message);
                }*/

                catch (Exception exp)
                {


                    Console.WriteLine("Error no se pudo cargar los datos " + exp.Message);
                }
       
   
            }

            foreach (var item in empleados)
            {
                item.MostrarDatos();
            }

        }
    }
}
