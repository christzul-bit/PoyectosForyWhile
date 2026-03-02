//Programa con while 12
string password = "aBc123";
string pass = "";
while(password != pass)
{
    Console.WriteLine("Ingrese su contraseña_");
    pass = Console.ReadLine();
    if(pass != password)
    {
        Console.WriteLine("Contraseña incorrecta, Intente otra vez");
    }else
    {
        Console.WriteLine("Bienvenido");
    }
}