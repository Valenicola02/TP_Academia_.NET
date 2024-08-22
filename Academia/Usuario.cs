using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Academia
{
    internal class Usuario : Personas
    {
        private int _IDUsuario;
        private string _NombreUsuario;
        private string _Clave;
        private bool _Habilitado;
        private bool _CambiaClave;

        public Usuario(int IDPersona, string Nombre, string Apellido, string Email, string Telefono, DateTime FechaNacimiento, int Legajo, int IDPlan, int IDUsuario, string NombreUsuario, string Clave, bool Habilitado, bool CambiaClave):base(IDPersona, Nombre, Apellido, Email, Telefono, FechaNacimiento, Legajo, IDPlan)
        {
            this.SetIDUsuario(IDUsuario);
            this.SetNombreUsuario(NombreUsuario);
            this.SetClave(Clave);
            this.SetHabilitado(Habilitado);
            this.SetCambiaClave(CambiaClave);
        }

        public void SetIDUsuario(int IDUsuario)
        {
            _IDUsuario = IDUsuario;
        }
        public int GetIDUsuario()
        {
            return _IDUsuario;
        }

        public void SetNombreUsuario(string NombreUsuario)
        {
            _NombreUsuario = NombreUsuario;
        }
        public string GetNombreUsuario()
        {
            return _NombreUsuario;
        }

        public void SetClave(string Clave)
        {
            _Clave = Clave;
        }
        public string GetClave()
        {
            return _Clave;
        }

        public void SetHabilitado(bool Habilitado)
        {
            _Habilitado = Habilitado;
        }
        public bool GetHabilitado()
        {
            return _Habilitado;
        }

        public void SetCambiaClave(bool CambiaClave)
        {
            _CambiaClave = CambiaClave;
        }
        public bool GetCambiaClave()
        {
            return _CambiaClave;
        }

    }
}
