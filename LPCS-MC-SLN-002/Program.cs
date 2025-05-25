using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPCS_MC_SLN_002
{
    internal class Program
    {
        //Tipo - Nombre - Valor
        static int edad = 5;
        static void Main(string[] args)
        {

            #region Video Introductorio. Resumen de Tipos de Datos

            //Imprime el valor de la variable que se encuentra afuera del método
            Console.WriteLine(edad);
            
            edad = 15;
            //Imprime el valor asignado en la línea 18, ya que éste reemplaza al valor inicial
            //"\n" representa un salto de línea para separar la "Region1" y "Region2"
            Console.WriteLine(edad + "\n");
            
            #endregion

            #region Video. Tipos de Datos: Int, Float y Double

            //Variables locales tipo "integer"
            int num1 = 13;
            int num2 = 5;

            //Imprime el valor de la variable "num1"
            Console.WriteLine(num1);

            //Operación Matemática
            int sum = num1 + num2;

            //Imprime el valor de la "Operación Matemática"
            Console.WriteLine(sum);

            //Imprimir mensaje utilizando la concatenación de textos
            Console.WriteLine("La suma de " + num1 + " más " + num2 + " da como resultado " + sum);

            //Variables locales tipo "double"
            double d1 = 3.2;
            double d2 = 1.337;

            //Operación Matemática con variables tipo "double"
            double sumd = d1 + d2;

            //Imprimir mensaje utilizando la concatenación de textos
            Console.WriteLine("La suma de " + d1 + " más " + d2 + " da como resultado " + sumd);

            //Operación Matemática con distintos tipos de variables
            //Lo hace correctamente porque la variable de la operación es un "double" y el resultado es "double" de lo contrario sería error
            double sumd1 = d1 + num2;

            //Imprimir mensaje utilizando la concatenación de textos
            Console.WriteLine("La suma de " + d1 + " más " + num2 + " da como resultado " + sumd1);

            //Crear y asignar el tipo de variables múltiples. Se subraya porque no se le han asigando valores
            int num3, num4, num5;

            //Asignarle valor a la variable "num3"
            num3 = 25;

            //Imprime el valor de la variable "num3"
            Console.WriteLine(num3);

            //Variables locales tipo "float". Tiene como particularidad que se le debe colocar "f" al final del valor porque sino da error
            float f1 = 3.5f;

            //Imprime el valor de la variable "num3"
            Console.WriteLine(f1 + "\n");

            #endregion

            #region Video. Tipos de Datos String y Algunos de sus Métodos 

            //Variables locales tipo "string"
            string MiNombre = "Victor";

            //Imprime el valor de la variable "MiNombre"
            Console.WriteLine(MiNombre);

            //Imprimir mensaje utilizando la concatenación de textos
            Console.WriteLine("Mi nombre es " + MiNombre);

            string Mensaje = "Mi nombre es " + MiNombre;

            //Imprimir mensaje que se encuentra dentro de la variable Mensaje
            Console.WriteLine(Mensaje);

            //Transformar el texto a Mayusculas
            string MensajeMayuscula = Mensaje.ToUpper();

            //Imprimir mensaje convertido a Mayusculas
            Console.WriteLine(MensajeMayuscula);

            //Transformar el texto a Minusculas
            string MensajeMinuscula = Mensaje.ToLower();

            //Imprimir mensaje convertido en Mayusculas
            Console.WriteLine(MensajeMinuscula);

            #endregion

            Console.Read();

        }
    }
}
