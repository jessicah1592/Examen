class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese el nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese el nombre de la asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese la nota del primer parcial (máximo 30%): ");
            asignatura.N1 = ValidarNota(30);

            Console.Write("Ingrese la nota del segundo parcial (máximo 30%): ");
            asignatura.N2 = ValidarNota(30);

            Console.Write("Ingrese la nota del tercer parcial (máximo 40%): ");
            asignatura.N3 = ValidarNota(40);

            asignatura.Imprimir();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Ingreso inválido. Debe ingresar un número entero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int ValidarNota(int max)
    {
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > max)
        {
            throw new ArgumentOutOfRangeException($"La nota debe estar entre 0 y {max}.");
        }
        return nota;
    }
}