namespace EspacioPersonal
{
    public enum Cargos { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }  // 'C' casado, 'S' soltero
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }

        public int Antiguedad
        {
            get { return DateTime.Now.Year - FechaIngreso.Year; }
        }

        public int Edad
        {
            get { return DateTime.Now.Year - FechaNacimiento.Year; }
        }

        public int AniosParaJubilarse
        {
            get { return 65 - Edad; }
        }

        public double Salario
        {
            get
            {
                double adicional = 0;

                // Antigüedad
                int antiguedad = Antiguedad;
                if (antiguedad > 20)
                    adicional += SueldoBasico * 0.25;
                else
                    adicional += SueldoBasico * 0.01 * antiguedad;

                // Cargo
                if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                    adicional *= 1.5;

                // Estado civil
                if (EstadoCivil == 'C' || EstadoCivil == 'c')
                    adicional += 150000;

                return SueldoBasico + adicional;
            }
        }
    }
}
