using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Curso
    {
        private int _IDCurso;
        private int _IDMateria;
        private int _IDComision;
        private int _AnioCalendario;
        private int _Cupo;
        private string _Descripcion;

        public Curso(int IDCurso, int IDMateria, int IDComision, int AnioCalendario, int Cupo, string Descripcion) 
        { 
            this.SetIDCurso(IDCurso);
            this.SetIDMateria(IDMateria);
            this.SetIDComision(IDComision);
            this.SetAnioCalendario(AnioCalendario);
            this.SetCupo(Cupo);
            this.SetDescripcion(Descripcion);
        }
        public void SetIDCurso(int IDCurso)
        {
            _IDCurso = IDCurso;
        }
        public int GetIDCurso()
        {
            return _IDCurso;
        }
        public void SetIDMateria(int IDMateria)
        {
            _IDMateria = IDMateria;
        }
        public int GetIDMateria()
        {
            return _IDMateria;
        }
        public void SetIDComision(int IDComision)
        {
            _IDComision = IDComision;
        }
        public int GetIDComision()
        {
            return _IDComision;
        }
        public void SetAnioCalendario(int AnioCalendario)
        {
            _AnioCalendario = AnioCalendario;
        }
        public int GetAnioCalendario()
        {
            return _AnioCalendario;
        }
        public void SetCupo(int Cupo)
        {
            _Cupo = Cupo;
        }
        public int GetCupo()
        {
            return _Cupo;
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
