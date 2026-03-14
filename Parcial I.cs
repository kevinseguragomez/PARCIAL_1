using System;

class Program
{
    static void Main(string[] args)
    {
        // 20 estudiantes con nombres y notas ya definidos
        string[] nombres = {
            "Briseyda", "Karla", "Alejandra", "Kevín", "Darwin", "Stuar", "Ian", "Andress", "Anderson", "Julio",
            "Madelin", "Kevin Darwin", "Estuardo", "Felipe", "Carlolina", "VincentVangGog", "Edith", "Leonel", "Arturo", "LuisGood"
        };

        double[] notas = {
            85.5, 92.0, 78.0, 65.5, 95.0, 88.5, 72.0, 90.0, 81.0, 70.0,
            96.5, 60.0, 84.0, 77.5, 93.0, 68.5, 89.0, 82.5, 75.0, 91.0
        };

        double suma = 0;
        double maxNota = double.MinValue;
        double minNota = double.MaxValue;
        string mejorEstudiante = "";
        string peorEstudiante = "";

        // Calcular suma, máximo y mínimo
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];

            if (notas[i] > maxNota)
            {
                maxNota = notas[i];
                mejorEstudiante = nombres[i];
            }

            if (notas[i] < minNota)
            {
                minNota = notas[i];
                peorEstudiante = nombres[i];
            }
        }

        double promedio = suma / notas.Length;

        // Imprimir SOLO lo solicitado
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Nota promedio: {promedio:F2}");
        Console.WriteLine($"Nota más alta: {maxNota:F2} - Estudiante: {mejorEstudiante}");
        Console.WriteLine($"Nota mínima:   {minNota:F2} - Estudiante: {peorEstudiante}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}