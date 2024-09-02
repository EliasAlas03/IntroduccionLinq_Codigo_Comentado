using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Medico' que hereda de la clase 'Empleado'
    public class Medico : Empleado
    {
        // Propiedad 'nombre' de tipo string con acceso público, representa el nombre del médico
        // Esta propiedad en la clase 'Medico' oculta la propiedad 'nombre' heredada de 'Empleado'
        public string nombre { get; set; }
    }
}
