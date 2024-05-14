using laboratorio_2_Parcial;
using System.Drawing;
using System.Text;

namespace Biblioteca
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            string esResidente = this.esResidente ? "SI" : "NO";
            sb.AppendLine($"¿Finalizo residencia? {esResidente}");
            sb.AppendLine("ATENCIONES:");

            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }

            return sb.ToString();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }


    }
}
