using EspacioCalculadora;
//Nunca debe tener nada por arriba


Console.WriteLine("Hello, World!V1");
//Ejercicio 1

Calculadora NuevaCalculadora = new Calculadora(); //Creo una variable de clase Calculadora con memoria dinamica

//Declaracion de variables
int nume;
string ingresado;
bool resultado;
int num;

do
{
    Console.WriteLine("Calculadora Reiterativa para el numero {0}",NuevaCalculadora.Resultado);
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("5.Limpiar");
    Console.WriteLine("6.Salir");


    do
    {
        Console.WriteLine("\nIngrese una opción");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado || nume < 1 || nume > 6);

    switch (nume)
    {
        case 1:
            num = numero();
            NuevaCalculadora.Sumar(num);
            break;
        case 2:
            num = numero();
            NuevaCalculadora.Restar(num);
            break;
        case 3:
            num = numero();
            NuevaCalculadora.Multiplicar(num);
            break;
        case 4:
            num = numeroParaDividir();
            NuevaCalculadora.Dividir(num);
            break;
        case 5:
            NuevaCalculadora.Limpiar();
            break;
    }

} while (nume != 6);

static int numero()
{
    string ingresado;
    int nume;
    bool resultado;
    do
    {
        Console.Write("\nIngrese un numero: ");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado);

    return (nume);
}

static int numeroParaDividir()
{
    string ingresado;
    int nume;
    bool resultado;
    do
    {
        Console.Write("\nIngrese un numero: ");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado || nume == 0);

    return (nume);
}