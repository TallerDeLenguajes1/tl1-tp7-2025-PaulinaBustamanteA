using EspacioCalculadora;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        string opcion;

        do
        {
            Console.WriteLine($"Resultado actual: {calc.Resultado}");
            Console.WriteLine("Elija operación: sumar, restar, multiplicar, dividir, limpiar, salir");
            opcion = Console.ReadLine().ToLower();

            if (opcion == "salir")
                break;

            if (opcion == "limpiar")
            {
                calc.Limpiar();
                continue;
            }

            Console.Write("Ingrese el número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

           switch (opcion)
{
    case "sumar": calc.Sumar(numero); break;
    case "restar": calc.Restar(numero); break;
    case "multiplicar": calc.Multiplicar(numero); break;
    case "dividir": calc.Dividir(numero); break;
    default: Console.WriteLine("Operación no válida."); break;
}


        } while (true);
    }
}
