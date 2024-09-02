using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Habitante' dentro del namespace 'IntroduccionLinq'
    public class Habitante
    {
        // Propiedad 'IdHabitante' de tipo entero con acceso público, utilizada para identificar de forma única cada habitante
        public int IdHabitante { get; set; }

        // Propiedad 'Nombre' de tipo string con acceso público, representa el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad 'Edad' de tipo entero con acceso público, representa la edad del habitante
        public int Edad { get; set; }

        // Propiedad 'IdCasa' de tipo entero con acceso público, representa el identificador de la casa en la que vive el habitante
        public int IdCasa { get; set; }

        // Método 'datosHabitante' que devuelve una cadena con la información completa del habitante
        public string datosHabitante()
        {
            // Retorna una cadena que contiene el nombre, la edad y el identificador de la casa del habitante
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
