//Ejercicio 1
//En este archivo solamente se crean las clases

namespace EspacioCalculadora;

//Creo una clase publica capaz de ser accesible con "."
public class Calculadora
{
    //Todo lo que se declare aquí son los campos o atributos de mi clase, luego se trabaja como una estructura en c

    private double dato; //Creo un dato de forma privada que se inicializa en 0
    public double Resultado {get => dato;}
    //get copio valor, set asigno valor
    public void Sumar(double termino){
        dato+=termino;
    }
    public void Restar(double termino){
        dato -= termino;
    }
    public void Multiplicar(double termino){
        dato *= termino;
    }
    public void Dividir(double termino){
        dato /= termino;
    }
    public void Limpiar(){
        dato = 0;
    }
}

//Los datos de alguna clase siempre deben ser privados mientras que las funciones que lo editan tienen que ser publicas


