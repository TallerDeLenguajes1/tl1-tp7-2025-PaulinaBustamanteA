using EspacioPersonal;

class Program
{
    static void Main()
    {
        Empleado[] empleados = new Empleado[3];

        for (int i = 0; i < empleados.Length; i++)
        {
            empleados[i] = new Empleado();

            Console.WriteLine($"\n--- Ingreso de datos del empleado {i + 1} ---");
            Console.Write("Nombre: ");
            empleados[i].Nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            empleados[i].Apellido = Console.ReadLine();

            Console.Write("Fecha de nacimiento (yyyy-mm-dd): ");
            empleados[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.Write("Estado civil (C=casado, S=soltero): ");
            empleados[i].EstadoCivil = char.Parse(Console.ReadLine());

            Console.Write("Fecha de ingreso (yyyy-mm-dd): ");
            empleados[i].FechaIngreso = DateTime.Parse(Console.ReadLine());

            Console.Write("Sueldo básico: ");
            empleados[i].SueldoBasico = double.Parse(Console.ReadLine());

            Console.WriteLine("Cargo (0=Auxiliar, 1=Administrativo, 2=Ingeniero, 3=Especialista, 4=Investigador): ");
            empleados[i].Cargo = (Cargos)int.Parse(Console.ReadLine());
        }

        double totalSalarios = 0;
        Empleado proximoAJubilarse = empleados[0];

        foreach (Empleado emp in empleados)
        {
            totalSalarios += emp.Salario;
            if (emp.AniosParaJubilarse < proximoAJubilarse.AniosParaJubilarse)
                proximoAJubilarse = emp;
        }

        Console.WriteLine($"\nMonto total de salarios: {totalSalarios}");

        Console.WriteLine("\nEmpleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {proximoAJubilarse.Nombre} {proximoAJubilarse.Apellido}");
        Console.WriteLine($"Edad: {proximoAJubilarse.Edad}");
        Console.WriteLine($"Antigüedad: {proximoAJubilarse.Antiguedad}");
        Console.WriteLine($"Años para jubilarse: {proximoAJubilarse.AniosParaJubilarse}");
        Console.WriteLine($"Salario: {proximoAJubilarse.Salario}");
    }
}
