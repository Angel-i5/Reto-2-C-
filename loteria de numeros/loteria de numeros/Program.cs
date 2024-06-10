// See https://aka.ms/new-console-template for more information

Console.WriteLine("introduce 6 numeros para la loteria entre 1 y 49");


Random random = new Random();
HashSet<int> numerosAleatorios = new HashSet<int>();

while (numerosAleatorios.Count <= 6)
{
    int numeroAleatorio = random.Next(1, 49);
    if (!numerosAleatorios.Contains(numeroAleatorio))
    {
        numerosAleatorios.Add(numeroAleatorio);
    }
    
};

 

HashSet<int> numerosUsuario = new HashSet<int>(6);

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

foreach (int resultados in numerosUsuario)
{
    if (numerosUsuario.Contains(resultados))
    {
        aciertos++;
    }
}
  Console.WriteLine("Número de aciertos: " + aciertos);

  Console.WriteLine("los numeros ganadores son");
foreach (int numerosGanadores in numerosAleatorios)
{
  
 Console.WriteLine($"{numerosGanadores}");
};

