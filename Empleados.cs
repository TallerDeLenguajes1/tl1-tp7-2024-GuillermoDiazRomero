namespace EspacioEmpleados;


public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Inverstigador
}
public class Empleados{
    
    
    private string? nombre;
    private string? apellido;
    private char EstadoCivil;


    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    private DateTime fechaNac;

    private double SueldoBasico;

    private Cargos cargo;



}