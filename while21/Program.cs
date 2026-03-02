//Programa con while 11
int resultado = 0;
while(resultado <= 100)
{
    Console.WriteLine("Ingrese un número_");
    int num = int.Parse(Console.ReadLine());
    resultado += num;
    Console.Clear();
}
Console.WriteLine($"La sumatoria total es {resultado}");
