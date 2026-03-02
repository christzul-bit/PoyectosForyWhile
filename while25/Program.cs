//Programa con while 15
int opcion = -1;
while(opcion != 4)
{
    Console.WriteLine("Seleccione una opción \n" +
        "1)Saludar \n" +
        "2)Contar a 3 \n" +
        "3)Contar a 5 \n" +
        "4)Salir_");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola");
            break;
        case 2:
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
            break;
        case 3:
            for(int j = 1; j <= 5; j++)
            {
                Console.WriteLine(j);
            }
            break;
        case 4: Console.WriteLine("Nos vemos_"); break;
        default: Console.WriteLine("Opcion invalida"); break;
    }
    Console.WriteLine("Preciona cualquier tecla para continuar_");
    Console.ReadLine();
    Console.Clear();
}