//Programa while 10
Console.WriteLine("Ingrese un numero entero_");
int num = int.Parse(Console.ReadLine());
int contador = 0;
int cifras = 1;
if(num < 0)
{
    num *= -1;
}else if(num == 0)
{
    contador = 1;
}
while(cifras < num)
{
    contador++;
    cifras *= 10;
}
Console.WriteLine($"Tu número tiene {contador} cifras");