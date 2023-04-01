// See https://aka.ms/new-console-template for more information
void matriz()
{
    string[] nombre = new string[]
{
    "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
};
    foreach (string n in nombre)
    {
        Console.WriteLine("nombre=" + n);
    }
    int[] notas = new int[]
    {
        50,90,85,73,95
    };
    int promedio = 0;
    foreach(int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio es=" + promedio);

    int notaMaxima = 0;
    int indiceMaximo = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaMaxima)
        {
            notaMaxima = notas[i];
            indiceMaximo = i;
        }
    }

    string nombreMaximo = nombre[indiceMaximo];
    Console.WriteLine("La nota más alta es= " + notaMaxima + " y fue obtenida por " + nombreMaximo);
}



matriz();
