using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Modulo
    {
        private int _IDModulo;
        private string _Descripcion;
        private string _Ejecuta;

        public Modulo(int IDModulo, string Descripcion, string Ejecuta) 
        {
            this.SetIDModulo(IDModulo);
            this.SetDescripcion(Descripcion);  
            this.SetEjecuta(Ejecuta);  
        }

        public void SetIDModulo(int IDModulo)
        {
            _IDModulo = IDModulo;
        }
        public int GetIDModulo()
        {
            return _IDModulo;
        }
        public void SetDescripcion(string Descripcion)
        {
            _Descripcion = Descripcion;
        }
        public string GetDescripcion()
        {
            return _Descripcion;
        }
        public void SetEjecuta(string Ejecuta)
        {
            _Ejecuta = Ejecuta;
        }
        public string GetEjecuta()
        {
            return _Ejecuta;
        }
    }
}
