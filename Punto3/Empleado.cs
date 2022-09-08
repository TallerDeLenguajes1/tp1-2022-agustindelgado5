using System;
using System.Collections.Generic;
using System.Text;

namespace TP1DelgadoCarlosAgustinTaller2_2022
{
  
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaIngreso { get; set; }


        public string PuestoProfesionales { get; set; }

        public float Sueldo { get; set; }
        
         //public Estado Estado { get => Estado; set => Estado = value; }

        public int CantidadHijos { get; set; }



        /*
        public Empleado(string _Nombre, String _Apellido, String _Direccion, DateTime _FechaIngreso, string _PuestoDatosProfesionales, float _sueldo,Estado _estado)
        {
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Direccion = _Direccion;
            this.FechaIngreso = _FechaIngreso;
            this.PuestoProfesionales = _PuestoDatosProfesionales;
            this.Sueldo = _sueldo;
            this.Estado = _estado;


        }*/
        
        public Empleado(string _Nombre, String _Apellido, String _Direccion, DateTime _FechaIngreso, string _PuestoDatosProfesionales, float _sueldo)
        {
            this.Nombre = _Nombre;
            this.Apellido = _Apellido;
            this.Direccion = _Direccion;
            this.FechaIngreso = _FechaIngreso;
            this.PuestoProfesionales = _PuestoDatosProfesionales;
            this.Sueldo = _sueldo;
           


        }

        public Empleado()
        {

        }
        /*
         a) La clase empleado deberá calcular la antigüedad en la empresa, la edad del
        empleado y el salario. Este se calcula de acuerdo a la fórmula: Salario = Sueldo
        Básico + Adicional – Descuento
         */
        public int Antiguedad()
        {
            var fechaEmp = new DateTime(DateTime.Today.Year,FechaIngreso.Month,FechaIngreso.Day);

            return (DateTime.Today - fechaEmp).Days >= 0 ? DateTime.Today.Year - FechaIngreso.Year : DateTime.Today.Year - FechaIngreso.Year - 1;
        }

        public int Edad()
        {
            var fechaEmp = new DateTime(DateTime.Today.Year, FechaIngreso.Month, FechaIngreso.Day);

            return (DateTime.Today - fechaEmp).Days >= 0 ? DateTime.Today.Year - FechaIngreso.Year : DateTime.Today.Year - FechaIngreso.Year - 1;
        }

        public float Salario()
        {
            float adicional = 0;
            float descuento = 0;
           
            if (Antiguedad() >= 20)
            {
                adicional = (float)0.25;
            }
            else
            {
                adicional =(float) 0.1*Antiguedad();
                descuento = (float)0.15 * Sueldo;

            }
            return (Sueldo + adicional) - descuento;
        }

        public string MostrarDatosEmp()
        {
            return "\nApellido: " + Apellido + "Nombre: " + Nombre + "\nEdad: " + Edad() + "\nAntiguedad:" + Antiguedad() + "\nSalario:" + Salario() + "\n";

        }

        public void MostrarDatos()
        {
            Console.WriteLine($"\t{Apellido}, {Nombre}.");
            Console.WriteLine("\tEdad: " + Edad() + " años.");
            Console.WriteLine("\tAntigüedad: " + Antiguedad() + " años.");
            Console.WriteLine("\tSalario: " + Salario() + " USDC.");
            Console.WriteLine();
        }



    }
}
