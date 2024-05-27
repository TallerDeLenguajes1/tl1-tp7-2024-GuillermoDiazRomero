namespace EspacioEmpleados;


public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleados{
    
    private string? nombre; private string? apellido; private char EstadoCivil; private DateTime fechaNac; private Cargos cargo; private double SueldoBasico; private DateTime fechaIngreso;private int? antiguedadEmpleado; private int? edadEmpleado; private int? aniosParaJubilarse; private int? salarioTotal;
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public int? AntiguedadEmpleado { get => antiguedadEmpleado; set => antiguedadEmpleado = value; }
    public int? EdadEmpleado { get => edadEmpleado; set => edadEmpleado = value; }
    public int? AniosParaJubilarse { get => aniosParaJubilarse; set => aniosParaJubilarse = value; }
    public int? SalarioTotal { get => salarioTotal; set => salarioTotal = value; }

    
    public int calcularEdad(){
        DateTime actual = DateTime.Now;
        int edad = actual.Year - fechaNac.Year;
        if (actual < fechaNac.AddYears(edad)){
            edad--;
        }
        return edad;
    }

    public int calcularAntiguedad(){
        DateTime actual = DateTime.Now;
        int antiguedad = actual.Year - fechaIngreso.Year;
        return antiguedad;
    }

    public int jubilacion(int ed){
        int jubila = 65 - ed;
        return jubila;
    }

    public double calcularSalario(int anti){
        double salario = SueldoBasico1;
        if (anti < 20){
            salario *= 1 + (anti/100);
        }
        else{
            salario *= 1.25;
        }
        if (Cargo == Cargos.Ingeniero && Cargo == Cargos.Especialista){
            salario *= 1.5;
        }
        if(EstadoCivil == 'c'){
            salario += 150000;
        }

        Console.WriteLine("Su salario es: " + salario);
        return salario;
    }
}
