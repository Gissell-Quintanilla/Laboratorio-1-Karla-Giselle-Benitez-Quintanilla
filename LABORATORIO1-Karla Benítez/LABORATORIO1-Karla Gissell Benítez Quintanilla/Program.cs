
using LABORATORIO1_Karla_Gissell_Benítez_Quintanilla.Entidades;
using LABORATORIO1_Karla_Gissell_Benítez_Quintanilla.Negocio;

Console.WriteLine("Escribe tu nombre: ");
String nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe tu sexo: ");
String sexo = Console.ReadLine();

Console.WriteLine("Escribe tu peso: ");
Double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe tu altura: ");
Double altura = Convert.ToDouble(Console.ReadLine());

Persona persona = new Persona();
persona.nombre = nombre; 
persona.edad = edad;
persona.sexo = sexo;
persona.peso = peso; 
persona.altura = altura;

clsPersona clsP = new clsPersona();

Console.WriteLine("\n" + clsP.calcularIMC(persona));
Console.WriteLine("\n" + clsP.esMayorDeEdad(persona));
