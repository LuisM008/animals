using System;
class Animal
{
public string Nombre;
public int Edad;
//constructor
public Animal(string nombre,int edad)
{
    Nombre=nombre;
    Edad=edad;
}
//Metodo
public void HacerSonido()
{
    Console.WriteLine(Nombre+ "hace sonido.");
}

//Metodo para mostrar info
public void MostarInfo()
{
    Console.WriteLine("Nombre:"+ Nombre+ "Edad"+Edad);
}
}