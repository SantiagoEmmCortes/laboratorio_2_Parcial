using laboratorio_2_Parcial;
using System.Text;

namespace Biblioteca
{
    public class Paciente : Persona
    {
        public string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(nombre, apellido, nacimiento, barrioResidencia)
        {
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Reside en {barrioResidencia}");
            sb.AppendLine($"{Diagnostico}");

            return sb.ToString();
        }
    }
}
