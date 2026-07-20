namespace Tarea_3__Flujo_de_control_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos estudiantes desea registrar? ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            string[] estudiantes = new string[cantidad];
            double[][] notas = new double[cantidad][];
            double[] promedioFinal = new double[cantidad];
            string[] resultado = new string[cantidad];

            for (int indice = 0; indice < cantidad; indice++)
            {
                Console.WriteLine("--- Estudiante {0} ---", indice + 1);
                Console.Write("Nombre: ");
                estudiantes[indice] = Console.ReadLine();

                notas[indice] = new double[4];

                for (int j = 0; j < 4; j++)
                {
                    notas[indice][j] = LeerNota("Nota {0}: ", j + 1);
                }

                double suma = 0;

                for (int j = 0; j < 4; j++)
                {
                    suma += notas[indice][j];
                }

                promedioFinal[indice] = suma / 4;
                resultado[indice] = promedioFinal[indice] >= 70 ? "Aprobado" : "Reprobado";
            }

            Console.WriteLine();
            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine();

            Console.WriteLine(string.Format("{0,-25} {1,-8} {2,-8} {3,-8} {4,-8} {5,-10} {6,-10}",
                "Estudiante", "Nota 1", "Nota 2", "Nota 3", "Nota 4", "Promedio", "Estatus"));
            Console.WriteLine(new string('-', 80));

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(string.Format("{0,-25} {1,-8} {2,-8} {3,-8} {4,-8} {5,-10} {6,-10}",
                    estudiantes[i], notas[i][0], notas[i][1], notas[i][2], notas[i][3], promedioFinal[i], resultado[i]));
            }

            Console.ReadKey();
        }

        static double LeerNota(string mensaje, int numero)
        {
            double nota;
            Console.Write(string.Format(mensaje, numero));
            nota = double.Parse(Console.ReadLine());

            while (nota < 0 || nota > 100)
            {
                Console.WriteLine("Nota inválida. Debe ser entre 0 y 100.");
                Console.Write(string.Format(mensaje, numero));
                nota = double.Parse(Console.ReadLine());
            }

            return nota;
        }
    }
}
