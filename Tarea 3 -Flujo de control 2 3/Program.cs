namespace Tarea_3__Flujo_de_control_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos estudiantes desea registrar? ");
            int n = int.Parse(Console.ReadLine());

            string[] nombres = new string[n];
            double[] notas1 = new double[n];
            double[] notas2 = new double[n];
            double[] notas3 = new double[n];
            double[] notas4 = new double[n];
            double[] promedios = new double[n];
            string[] estatus = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"--- Estudiante {i + 1} ---");
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();
                Console.Write("Nota 1: ");
                notas1[i] = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                notas2[i] = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                notas3[i] = double.Parse(Console.ReadLine());
                Console.Write("Nota 4: ");
                notas4[i] = double.Parse(Console.ReadLine());

                promedios[i] = (notas1[i] + notas2[i] + notas3[i] + notas4[i]) / 4;

                if (promedios[i] >= 70)
                    estatus[i] = "Aprobado";
                else
                    estatus[i] = "Reprobado";
            }

            Console.WriteLine();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine();

            Console.WriteLine(string.Format("{0,-25} {1,-8} {2,-8} {3,-8} {4,-8} {5,-10} {6,-10}",
                "Estudiante", "Nota 1", "Nota 2", "Nota 3", "Nota 4", "Promedio", "Estatus"));
            Console.WriteLine(new string('-', 80));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0,-25} {1,-8} {2,-8} {3,-8} {4,-8} {5,-10} {6,-10}",
                    nombres[i], notas1[i], notas2[i], notas3[i], notas4[i], promedios[i], estatus[i]));
            }

            Console.ReadKey();
        }
    }
}
