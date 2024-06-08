// See https://aka.ms/new-console-template for more information



Console.WriteLine("calculando estadisticasde calificasiones");
 
List<double> listaCalificasiones = new List<double>();



for (double i = 0; i < 3; i++)
{
    if (true)
    {
        Console.WriteLine("introdusca una calificasion por ejemplo 10,0");
        double notas = double.Parse(Console.ReadLine());
        listaCalificasiones.Add(notas);
    }
};

double notaMasAlta = listaCalificasiones [0];
double notaMasBaja = listaCalificasiones[0];
double totalNotas = listaCalificasiones[0];

foreach (double nota in listaCalificasiones)
{
    totalNotas += nota;

    if (nota > notaMasAlta)
    {
        notaMasAlta = nota;
    }
    if (nota < totalNotas) { 

        notaMasBaja = nota;
    
    }
}

double promedio = (double)totalNotas / listaCalificasiones.Count;

Console.WriteLine("nota mas alta es " + notaMasAlta);
Console.WriteLine("nota mas baja es " + notaMasBaja);
Console.WriteLine("el promedio es " + promedio);




