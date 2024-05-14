using Biblioteca;
using System.Text;

namespace laboratorio_2_Parcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get { return $"{apellido}, {nombre}"; }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }


        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{NombreCompleto}");
            sb.AppendLine($"EDAD: {Edad}");
            sb.Append(p.FichaExtra());

            return sb.ToString();
        }

        internal abstract string FichaExtra();

        public override string ToString()
        {
            return NombreCompleto;
        }


    }
}
