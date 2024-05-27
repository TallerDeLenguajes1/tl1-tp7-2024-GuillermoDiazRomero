using EspacioCalculadora;
using EspacioEmpleados;
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
    Console.WriteLine("Calculadora Reiterativa para el numero {0}", NuevaCalculadora.Resultado);
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



//Ejercicio 2

Empleados[] Empleado = new Empleados[3];

//Declaración de Variables
string letra;
char estado;
int edad;
string entrada;
int opcion;
double total = 0;
float sal;
int anti;
int jubi;
int mayor = 100;
int persona = -99999;


//Carga de datos de empleados
for (int i = 0; i < 3; i++)
{
    Empleado[i] = new Empleados();
    Console.WriteLine($"Ingrese los datos del {i+1}er empleado:");
    //Apellido y Nombre
    Console.Write("Apellido: ");
    Empleado[i].Apellido = Console.ReadLine();
    Console.Write("Nombre: ");
    Empleado[i].Nombre = Console.ReadLine();
    //Estado Civil
    Console.WriteLine("Ingrese su estado civil");
    do
    {
        Console.Write(" (c casado, s soltero): ");
        letra = Console.ReadLine();
        resultado = char.TryParse(letra, out estado);
    } while (!resultado && (estado != 'c' || estado != 's'));
    Empleado[i].EstadoCivil1 = estado;

    //Salarios
    do
    {
        Console.Write("\nIngrese su salario: ");
        ingresado = Console.ReadLine();
        resultado = float.TryParse(ingresado, out sal);
    } while (!resultado || sal < 0);
    Empleado[i].SueldoBasico1 = sal;

    //Fechas
    //Nacimiento
    DateTime fechanac;
    Console.WriteLine("Ingrese su Fecha de Nacimiento");
    do
    {
        Console.Write("\n (Formato AAAA-MM-DD): ");
        ingresado = Console.ReadLine();
        resultado = DateTime.TryParse(ingresado, out fechanac);
    } while (!resultado);
    Empleado[i].FechaNac = fechanac;

    //Fecha Ingreso
    DateTime Ingreso;
    Console.WriteLine("Ingrese su Fecha de Ingreso");
    do
    {
        Console.Write("(Formato AAAA-MM-DD): ");
        ingresado = Console.ReadLine();
        resultado = DateTime.TryParse(ingresado, out Ingreso);
    } while (!resultado);
    Empleado[i].FechaIngreso = Ingreso;

    //Cargo
    Console.WriteLine("Ingrese su cargo:");
    
    do
    {
        Console.WriteLine("1.Auxiliar");
        Console.WriteLine("2.Administrativo");
        Console.WriteLine("3.Ingeniero");
        Console.WriteLine("4.Especialista");
        Console.WriteLine("5.Investigador");
        entrada = Console.ReadLine();

    } while (!int.TryParse(entrada, out opcion) && (opcion > 0 || opcion <= 5));
    Empleado[i].Cargo = (Cargos)opcion;

    //Calculando Edad-Antiguedad-Jubilacion-Salario
    edad = Empleado[i].calcularEdad();
    Empleado[i].EdadEmpleado = edad;
    Console.WriteLine("Edad: " + edad);

    anti = Empleado[i].calcularAntiguedad();
    Empleado[i].AntiguedadEmpleado = anti;
    Console.WriteLine("Antiguedad: " + anti);

    jubi = Empleado[i].jubilacion(edad);
    Empleado[i].AniosParaJubilarse = jubi;
    if (jubi > 0)
    {
        Console.WriteLine($"Le quedan {jubi} años");
    }
    else
    {
        Console.WriteLine("Ya se puede jubilar");
    }

    total += Empleado[i].calcularSalario(anti);
    if (jubi < mayor)
    {
        mayor = jubi;
        persona = i;
    }
}

Console.WriteLine($"Cantidad total en salarios a pagar: {total}");

if(persona != -9999){
    Console.Write("Datos de la persona más próxima a jubilarse:");
    Console.Write("Apellido: ");
    Console.Write(Empleado[persona].Apellido);
    Console.Write("\n");
    Console.Write("Nombre: ");
    Console.Write(Empleado[persona].Nombre);
    Console.Write("\n");
    Console.Write("Edad: ");
    Console.Write(Empleado[persona].EdadEmpleado);
    Console.Write("\n");
    Console.Write("Fecha de Nacimiento: ");
    Console.Write(Empleado[persona].FechaNac);
    Console.Write("\n");
    Console.Write("Estado Civil: ");
    Console.Write(Empleado[persona].EstadoCivil1);
    Console.Write("\n");
    Console.Write("Cargo que ocupa: ");
    Console.Write(Empleado[persona].Cargo);
    Console.Write("\n");
    Console.Write("Fecha de ingreso al trabajo:");
    Console.Write(Empleado[persona].FechaIngreso);
    Console.Write("\n");
    Console.Write("Antiguedad en el Empleo: ");
    Console.Write(Empleado[persona].AntiguedadEmpleado);
    Console.Write("\n");
    Console.Write("Años para jubilarse: ");
    Console.Write(Empleado[persona].AniosParaJubilarse);
    Console.Write("\n");
    Console.Write("Sueldo en bruto: ");
    Console.Write(Empleado[persona].SueldoBasico1);
    Console.Write("\n");
    Console.Write("Salario TOTAL: ");
    Console.Write(Empleado[persona].SalarioTotal);
    Console.Write("\n");
}
else{
    Console.WriteLine("Sus empleados estan todos para jubilarse");
}

