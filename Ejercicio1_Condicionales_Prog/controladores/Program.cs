//Ruben Bernal Ramos
//CSI1

using Ejercicio1_Condicionales_Prog.servicios;
using System.Net.NetworkInformation;

namespace Ejercicio1_Condicionales_Prog.controladores
{
    /// <summary>
    /// Clase principal de nuestra aplicación
    /// rbr - 231023
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método main donde encontraremos la parte principal de nuestra aplicación junto con casi la 
        /// totalidad del código completo
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            //Declaro la variable
            int numero;

            //Instancio la interfaz y la implementacion
            numeroInterfaz ni = new numeroImplementacion();

            //Pido el numero por consola
            numero = ni.guardaNumero();

            //Controlo si es par o impar
            if (numero%2==0)
            {
                Console.WriteLine("El número " + numero + " es par");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar");
            }
        }
    }
}