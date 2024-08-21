using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Usuario : Personas
    {
        private int _IDUsuario;
        private string _NombreUsuario;
        private string _Clave;
        private bool _Habilitado;
        private bool _CambiaClave;
        public Usuario() { }

    }
}
