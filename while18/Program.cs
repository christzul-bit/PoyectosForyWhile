//Programa con while 8
Console.WriteLine("Ingrese un número para obtener su factorial_");
int num = int.Parse(Console.ReadLine());
int resultado = 1;
if(num == 0)
{
    resultado = 0;
}
while(num >= 1)
{
    resultado = resultado * num;
    num--;
}
Console.WriteLine($"El factorial es {resultado}");
