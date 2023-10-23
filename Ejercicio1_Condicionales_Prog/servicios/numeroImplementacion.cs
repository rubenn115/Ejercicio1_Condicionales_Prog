//Ruben Bernal Ramos
//CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Condicionales_Prog.servicios
{
    /// <summary>
    /// Implemento la interfaz de numero
    /// rbr - 231023
    /// </summary>
    internal class numeroImplementacion : numeroInterfaz
    {
        /// <summary>
        /// Método que solicitará por consola un número entero, lo guardará y lo devolverá
        /// rbr - 231023
        /// </summary>
        /// <returns></returns>
        public int guardaNumero()
        {
            int numero;

            Console.WriteLine("Escribe un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }
    }
}
