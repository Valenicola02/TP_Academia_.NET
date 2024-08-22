using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Especialidad
    {
        private int _IDEspecialidad;
        private string _Descripcion;

        public Especialidad(int IDEspecialidad, string Descripcion)
        {
            this.SetIDEspecialidad(IDEspecialidad);
            this.SetDescripcion(Descripcion);   
        }
        public void SetIDEspecialidad(int IDEspecialidad)
        {
            _IDEspecialidad = IDEspecialidad;
        }
        public int GetIDEspecialidad()
        {
            return _IDEspecialidad;
        }
        public void SetDescripcion(string Descripcion)
        {
            _Descripcion = Descripcion;
        }
        public string GetDescripcion()
        {
            return _Descripcion;
        }
    }
}
