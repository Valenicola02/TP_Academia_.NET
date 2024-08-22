using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class AlumnoInscripcion
    {
        private int _IDInscripcion;
        private int _IDAlumno;
        private int _IDCurso;
        private string _Condicion;
        private int _Nota;

        public AlumnoInscripcion(int IDInscripcion, int IDAlumno, int IDCurso, string Condicion, int Nota)
        {
            this.SetIDInscripcion(IDInscripcion);
            this.SetIDAlumno(IDAlumno);
            this.SetIDCurso(IDCurso);
            this.SetCondicion(Condicion);
            this.SetNota(Nota);
        }
        public void SetIDInscripcion(int IDInscripcion)
        {
            _IDInscripcion = IDInscripcion;
        }
        public int GetIDInscripcion()
        {
            return _IDInscripcion;
        }
        public void SetIDAlumno(int IDAlumno)
        {
            _IDAlumno = IDAlumno;
        }
        public int GetIDAlumno() 
        {
            return _IDAlumno;
        }
        public void SetIDCurso(int IDCurso)
        {
            _IDCurso = IDCurso;
        }
        public int GetIDCurso()
        {
            return _IDCurso;
        }
        public void SetCondicion(string Condicion)
        {
            _Condicion = Condicion ;
        }
        public string GetCondicion()
        {
            return _Condicion;
        }
        public void SetNota(int Nota)
        {
            _Nota = Nota;
        }
        public int GetNota()
        {
            return _Nota;
        }
    }
}
