// See https://aka.ms/new-console-template for more information

Console.WriteLine("introduce un texto o parrafo");
string texto = Console.ReadLine();

string[] parrafo = texto.Split(new char[] { ' ' });

Dictionary<string,int> frecuencia = new Dictionary<string,int>();

foreach (string palabra in parrafo) 
{
    
    if (frecuencia.ContainsKey(palabra))
    {
        frecuencia[palabra]++;
    }
    else
    {
        frecuencia[palabra] = 1;
    }
}

foreach (var kvp in frecuencia)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}


