//programa con for 5
for(int i = 1; i <= 5; i++)
{
    Console.WriteLine($"La tabla de {i}");
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {j * i}");
    }
}