using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Enfermero' que hereda de la clase 'Empleado'
    public class Enfermero : Empleado
    {
        // Propiedad 'nombre' de tipo string con acceso público, representa el nombre del enfermero
        // Esta propiedad en la clase 'Enfermero' oculta la propiedad 'nombre' heredada de 'Empleado'
        public string nombre { get; set; }
    }
}
