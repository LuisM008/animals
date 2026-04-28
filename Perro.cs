class Perro : Animal
{
    //Atributo propio de Perro
    public string Raza;
    //Constructor
    public Perro(string nombre,int edad,string raza) 
    : base (nombre,edad)
    {
        Raza = raza ;
    }

    //Sobreescribe el metodo padre
    public new void HacerSonido()
    {
        Console.WriteLine(Nombre+"dice ¡Guau!");
    }
    //Metodo propio de Perro
    public void Buscar()
    {
        Console.WriteLine(Nombre+" esta buscando algo...");
    } 
}

class Program
{
    static void Main()
    {
        Perro miPerro= new Perro("Gorda",2,"Pastor Belga");
        miPerro.MostarInfo();
        miPerro.HacerSonido();
        miPerro.Buscar();

        Perro sePerro = new Perro("Chocolate",10,"Pitbull");
        sePerro.MostarInfo();
        sePerro.HacerSonido();
        sePerro.Buscar();

        Console.WriteLine("Raza:"+ miPerro.Raza);
        Console.WriteLine("Raza:"+ sePerro.Raza);
    }
}
