namespace Biblioteca
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }

        public Paciente Paciente
        {
            get { return paciente; }
        }

        public override string ToString()
        {
            return $"{fecha} se a atendido a {paciente.NombreCompleto}";
        }




    }

}
