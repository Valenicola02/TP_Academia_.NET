using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Plan
    {
        private int _IDPlan;
        private string _Descripcion;
        private int _IDEspecialidad;

        public Plan(int IDPlan, string Descripcion, int IDEspecialidad)
        {
            this.SetIDPlan(IDPlan);
            this.SetDescripcion(Descripcion);
            this.SetIDEspecialidad(IDEspecialidad);
        }
        public void SetIDPlan(int IDPlan)
        {
            _IDPlan = IDPlan;
        }
        public int GetIDPlan()
        {
            return _IDPlan;
        }

        public void SetDescripcion(string Descripcion)
        {
            _Descripcion = Descripcion;
        }
        public string GetDescripcion()
        {
            return _Descripcion;
        }
        public void SetIDEspecialidad(int IDEspecialidad)
        {
            _IDEspecialidad = IDEspecialidad;
        }
        public int GetIDEspecialidad()
        {
            return _IDEspecialidad;
        }
    }
}
