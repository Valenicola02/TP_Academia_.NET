using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class ModuloUsuario
    {
        private int _IDModuloUsuario;
        private int _IDModulo;
        private int _IDUsuario;
        private bool _PermiteAlta;
        private bool _PermiteBaja;
        private bool _PermiteModificacion;
        private bool _PermiteConsulta;

        public ModuloUsuario(int IDModuloUsuario, int IDModulo, int IDUsuario, bool PermiteAlta, bool PermiteBaja, bool PermiteModificacion, bool PermiteConsulta) 
        { 
            this.SetIDModuloUsuario(IDModuloUsuario);  
            this.SetIDModulo(IDModulo);   
            this.SetIDUsuario(IDUsuario);
            this.SetPermiteAlta(PermiteAlta);
            this.SetPermiteBaja(PermiteBaja);
            this.SetPermiteModificacion(PermiteModificacion);
            this.SetPermiteConsulta(PermiteConsulta);
        }
        public void SetIDModuloUsuario(int IDModuloUsuario)
        {
            _IDModuloUsuario = IDModuloUsuario;
        }
        public int GetIDModuloUsuario()
        {
            return _IDModuloUsuario;
        }

        public void SetIDModulo(int IDModulo)
        {
            _IDModulo= IDModulo;
        }
        public int GetIDModulo()
        {
            return _IDModulo;
        }

        public void SetIDUsuario(int IDUsuario)
        {
            _IDUsuario = IDUsuario;
        }
        public int GetIDUsuario()
        {
            return _IDUsuario;
        }

        public void SetPermiteAlta(bool PermiteAlta)
        {
            _PermiteAlta = PermiteAlta;
        }
        public bool GetPermiteAlta()
        {
            return _PermiteAlta;
        }

        public void SetPermiteBaja(bool PermiteBaja)
        {
            _PermiteBaja = PermiteBaja;
        }
        public bool GetPermiteBaja()
        {
            return _PermiteBaja;
        }
        public void SetPermiteModificacion(bool PermiteModificacion)
        {
            _PermiteModificacion = PermiteModificacion;
        }
        public bool PermiteModificacion()
        {
            return _PermiteModificacion;
        }
        public void SetPermiteConsulta(bool PermiteConsulta)
        {
            _PermiteConsulta = PermiteConsulta;
        }
        public bool GetPermiteConsulta()
        {
            return _PermiteConsulta;
        }

    }
}
