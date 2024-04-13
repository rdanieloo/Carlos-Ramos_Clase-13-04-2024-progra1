using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos_Ramos_Clase_13_04_2024_progra1
{
    internal class Carlos_Ramos_Clase_13_04_2024_progra1
    {

        public string Marca { get; set; }
        public int Añolanzamiento { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, año lanzamiento: {Añolanzamiento}");
        }

    }
}