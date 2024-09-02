using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Casa' dentro del namespace 'IntroduccionLinq'
    public class Casa
    {
        // Propiedad 'Id' de tipo entero con acceso público, utilizada para identificar de forma única cada objeto 'Casa'
        public int Id { get; set; }

        // Propiedad 'Direccion' de tipo string con acceso público, representa la dirección de la casa
        public string Direccion { get; set; }

        // Propiedad 'Ciudad' de tipo string con acceso público, representa la ciudad en la que se encuentra la casa
        public string Ciudad { get; set; }

        // Propiedad 'numeroHabitaciones' de tipo entero con acceso público, representa el número de habitaciones de la casa
        public int numeroHabitaciones { get; set; }

        // Método 'dameDatosCasa' que devuelve una cadena con la información completa de la casa
        public string dameDatosCasa()
        {
            // Retorna una cadena que contiene la dirección, ciudad y número de habitaciones de la casa
            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";
        }
    }
}
