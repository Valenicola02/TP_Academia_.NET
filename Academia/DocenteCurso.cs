using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class DocenteCurso
    {
        private int _IDDictado;
        private int _IDCurso;
        private int _IDDocente;
        private List<int> _TiposPersona = new List<int>();

        public DocenteCurso(int IDDictado, int IDCurso, int IDDocente) 
        { 
            this.SetIDDictado(IDDictado);
            this.SetIDCurso(IDCurso);
            this.SetIDDocente(IDDocente);
        }
        public void SetIDDictado(int IDDictado)
        {
            _IDDictado = IDDictado;
        }
        public int GetIDDictado()
        {
            return _IDDictado;
        }
        public void SetIDCurso(int IDCurso)
        {
            _IDCurso = IDCurso;
        }
        public int GetIDCurso()
        {
            return _IDCurso;
        }
        public void SetIDDocente(int IDDocente)
        {
            _IDDocente = IDDocente;
        }
        public int GetIDDocente()
        {
            return _IDDocente;
        }
    }
}
