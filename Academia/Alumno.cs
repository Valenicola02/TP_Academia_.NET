using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Alumno : Personas
    {
        public Alumno(int IDPersona, string Nombre, string Apellido, string Email, string Telefono, DateTime FechaNacimiento, int Legajo, int IDPlan) : base(IDPersona, Nombre, Apellido, Email, Telefono, FechaNacimiento, Legajo, IDPlan)
        {

        }
    }
}
