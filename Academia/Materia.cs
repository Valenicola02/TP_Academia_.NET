using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Materia
    {
        private int _IDMateria;
        private string _Descripcion;
        private int _HSSemanales;
        private int _HSTotales;
        private int _IDPlan;

        public Materia(int IDMateria, string Descripcion, int HSSemanales, int HSTotales, int IDPlan)
        {
            this.SetIDMeteria(IDMateria);
            this.SetDescripcion(Descripcion);
            this.SetHSSemanales(HSSemanales);
            this.SetHSTotales(HSTotales);  
            this.SetIDPlan(IDPlan);
        }

        public void SetIDMeteria(int IDMateria)
        {
            _IDMateria = IDMateria;
        }
        public int GetIDMateria()
        {
            return _IDMateria;
        }

        public void SetDescripcion(string Descripcion)
        {
            _Descripcion = Descripcion;
        }
        public string GetDescripcion()
        {
            return _Descripcion;
        }

        public void SetHSSemanales(int HSSemanales)
        {
            _HSSemanales = HSSemanales;
        }
        public int GetHSSemanales()
        {
            return _HSSemanales;
        }
        public void SetHSTotales(int HSTotales)
        {
            _HSTotales = HSTotales;
        }
        public int GetHSTotales()
        {
            return _HSTotales;
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
