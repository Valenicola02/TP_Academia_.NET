using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    internal class Personas
    {
        private int _IDPersona;
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Email;
        private string _Telefono;
        private DateTime _FechaNacimiento;
        private int _Legajo;
        private int _IDPlan;
        private List<string> _TiposPersona = new List<string>();

        public Personas(int IDPersona, string Nombre, string Apellido, string Email, string Telefono, DateTime FechaNacimiento, int Legajo, int IDPlan)
        {
            this.SetIDPersona(IDPersona);
            this.SetNombre(Nombre);
            this.SetApellido(Apellido);
            this.SetEmail(Email);
            this.SetTelefono(Telefono);
            this.SetFechaNacimiento(FechaNacimiento);
            this.SetLegajo(Legajo);
            this.SetIDPlan(IDPlan);
        }
        public void SetIDPersona(int IDPersona)
        {
            _IDPersona = IDPersona;
        }
        public int GetIDPersona()
        {
            return _IDPersona;
        }
        public void SetNombre(string Nombre)
        {
            _Nombre = Nombre;
        }
        public string GetNombre()
        {
            return _Nombre;
        }
        public void SetApellido(string Apellido)
        {
            _Apellido = Apellido;
        }
        public string GetApellido()
        {
            return _Apellido;
        }
        public void SetDireccion(string Direccion)
        {
            _Direccion = Direccion;
        }
        public string GetDireccion()
        {
            return _Direccion;
        }
        public void SetEmail(string Email)
        {
            _Email = Email;
        }
        public string GetEmail()
        {
            return _Email;
        }
        public void SetTelefono(string Telefono)
        {
            _Telefono = Telefono;
        }
        public string GetTelefono()
        {
            return _Telefono;
        }
        public void SetFechaNacimiento(DateTime FechaNacimiento)
        {
            _FechaNacimiento = FechaNacimiento;
        }
        public DateTime GetFechaNacimiento()
        {
            return _FechaNacimiento;
        }
        public void SetLegajo(int Legajo)
        {
            _Legajo = Legajo;
        }
        public int GetLegajo()
        {
            return _Legajo;
        }
        public void SetIDPlan(int IDPlan)
        {
            _IDPlan= IDPlan;
        }
        public int GetIDPlan()
        {
            return _IDPlan;
        }

    }
}

