using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Comision
    {
        private int _IDComision;
        private string _Descripcion;
        private int _AnioEspecialidad;
        private int _IDPlan;
        
        public Comision(int IDComision, string Descripcion, int AnioEspecialidad, int IDPlan) 
        { 
            this.SetIDComision(IDComision);
            this.SetDescripcion(Descripcion);  
            this.SetAnioEspecialidad(AnioEspecialidad);
            this.SetIDPlan(IDPlan);
        }
        public void SetIDComision(int IDComision)
        {
            _IDComision = IDComision;
        }
        public int GetIDComision() 
        {
            return _IDComision; 
        }
        public void SetDescripcion(string Descripcion)
        {
            _Descripcion = Descripcion;
        }
        public string GetDescripcion()
        {
            return _Descripcion;
        }
        public void SetAnioEspecialidad(int AnioEspecialidad)
        {
            _AnioEspecialidad = AnioEspecialidad;
        }
        public int GetAnioEspecialidad()
        {
            return _AnioEspecialidad;
        }
        public void SetIDPlan(int IDPlan)
        {
            _IDPlan = IDPlan;
        }
        public int GetIDPlan()
        {
            return _IDPlan;
        }
    }
}
