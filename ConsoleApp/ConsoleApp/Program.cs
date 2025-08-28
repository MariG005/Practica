
using static System.Runtime.InteropServices.JavaScript.JSType;

Clientes cliente = new Clientes();

cliente.Id = 1;
cliente.Nombre = "David";
cliente.Cedula = "2323232";
cliente.Asesor = new Asesores() { Id = 1, Nombre = "Mariana" };
cliente.Productos = new List<Productos>();
cliente.Productos.Add(new Productos() { Id = 1, Nombre = "PSP", Precio = 200 });
cliente.Productos.Add(new Productos() { Id = 2, Nombre = "Un plei", Precio = 500 });
cliente.Pase = "XD";

cliente.Productos = new List<Productos>
{
    new Productos { Id = 1, Nombre = "PSP", Precio = 200 },
    new Productos { Id = 1, Nombre = "PSP", Precio = 200 },
    new Productos { Id = 1, Nombre = "PSP", Precio = 200 },
    new Productos { Id = 1, Nombre = "PSP", Precio = 200 },
    new Productos { Id = 1, Nombre = "PSP", Precio = 200 },
};

decimal suma = 0;
int cont = 0;

foreach (var elemento in cliente.Productos)
{
    Console.WriteLine(elemento.Nombre);
    suma = suma + elemento.Precio;
    cont++;
}

Console.WriteLine(suma / cliente.Productos.Count);
Console.WriteLine(cliente.Asesor.Nombre);


public class Personas
{
    public int Id;
    public string? Nombre;
    public string? Cedula;
    public Asesores? Asesor;
    public List<Productos>? Productos; 
}


public class Clientes : Personas
{
    public string? Pase;

}


public class Productos
{
    public int Id;
    public string? Nombre;
    public decimal Precio;
}

public class Asesores
{
    public int Id;
    public string? Nombre;
}














