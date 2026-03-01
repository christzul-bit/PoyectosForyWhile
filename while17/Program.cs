//Programa con while 7
int num = 1;
int contador = 0;
while(num != 0)
{
    Console.Clear();
    Console.WriteLine("Ingrese un número, 0 termina el programa_");
    num = int.Parse(Console.ReadLine());
    if(num > 0)
    {
        contador++;
    }
}
Console.WriteLine($"La cantidad de números positivos ingresados es {contador}");