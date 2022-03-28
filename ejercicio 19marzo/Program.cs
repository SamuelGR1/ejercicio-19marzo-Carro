
using ejercicio_19marzo.clase;

Carro SamuelCarrito = new Carro("Honda Civic", 2022, "Negro", 150);


Console.WriteLine($"El carro de Samuel es un {SamuelCarrito.Marca}");
Console.WriteLine($" Modelo {SamuelCarrito.Modelo}");
Console.WriteLine($" Color {SamuelCarrito.Color}\n");
//Console.WriteLine($"Samuel's model car is {SamuelCarrito.Modelo}");


//ENCENDER EL MOTOR

string mensaje;
Console.WriteLine(SamuelCarrito.GetVelocidadActual());
mensaje=SamuelCarrito.EncenderMotor();
Console.WriteLine(mensaje);


for (int i = 0; i < 5; i++)
{
    mensaje=SamuelCarrito.acelerar();
    Console.WriteLine(mensaje);
}
for (int i = 0; i < 6; i++)
{
    mensaje=SamuelCarrito.Desacelerar();
    Console.WriteLine(mensaje);

}


//EL FRENO
//mensaje=SamuelCarrito.Frenado();
//Console.WriteLine(mensaje)


//APAGAR EL MOTOR
mensaje =SamuelCarrito.ApagarMotor();
Console.WriteLine(mensaje);

   mensaje = SamuelCarrito.pitar();
    Console.WriteLine(mensaje);

for (int i = 0; i < 3; i++)
{

    mensaje = SamuelCarrito.pitar();
    Console.WriteLine(mensaje);


}
