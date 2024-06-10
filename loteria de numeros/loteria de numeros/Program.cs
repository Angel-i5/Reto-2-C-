// See https://aka.ms/new-console-template for more information

Console.WriteLine("introduce 6 numeros para la loteria entre 1 y 49");

int[] numerosGanadores = new int[6];
Random random = new Random();

int numeroG = 0;
while (numeroG < 6)
{ int numeroAleatorio = random.Next(1, 50);

    if (!Array.Exists(numerosGanadores, element => element == numeroAleatorio))
    {
        numerosGanadores[numeroG] = numeroAleatorio;
        numeroG++;
    }
}


List<int> numerosUsuario = new List<int>(6);

for (int i = 0; i < 6; i++)
{

    Console.WriteLine("introduce el numero");
    int numero = int.Parse(Console.ReadLine());

    if (numerosUsuario.Contains(numero))
    {
        numerosUsuario.Add(numero);
       
    }
   

}

int aciertos = 0;

foreach (int numeroGanador in numerosGanadores)
{
    if (numerosUsuario.Contains(numeroGanador))
    {
        aciertos++;
      
    }

   
}
Console.WriteLine($"Número de aciertos: " + aciertos);

Console.WriteLine("Números ganadores:");
foreach (int loto in numerosGanadores)
{
    Console.WriteLine(loto);
};

if (aciertos == 6)
{
    Console.WriteLine("¡Felicidades! Has acertado todos los números.");
}





