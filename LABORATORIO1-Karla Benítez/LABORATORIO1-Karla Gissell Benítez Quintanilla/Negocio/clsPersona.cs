using LABORATORIO1_Karla_Gissell_Benítez_Quintanilla.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO1_Karla_Gissell_Benítez_Quintanilla.Negocio
{
    internal class clsPersona
    {
        public String calcularIMC(Persona persona)
        {
            Double pro = persona.peso / Math.Pow(persona.altura, 2);

            if (pro > 24 && pro < 25)
            {
                return persona.nombre + " tiene un peso ideal";

            }
            else if (pro < 24)
            {
                return persona.nombre + " está por debajo de su peso ideal";
            }
            else if(pro >= 25)
            {
                return persona.nombre + " tiene sobre peso";
            }
            return "";
        }

        public String esMayorDeEdad(Persona persona)
        {
            if(persona.edad >= 18)
            {
                return persona.nombre + " es mayor de edad";

            }
            else
            {
                return persona.nombre + " es menor de edad";
            }
        }
    }
}
