//Programa con while 9
Console.WriteLine("Ingrese el número para obtener su tabla de multiplicar_");
int num = int.Parse(Console.ReadLine());
int contador = 1;
while(contador <= 10)
{
    Console.WriteLine($"{num} x {contador} = {num * contador}");
    contador++;
}