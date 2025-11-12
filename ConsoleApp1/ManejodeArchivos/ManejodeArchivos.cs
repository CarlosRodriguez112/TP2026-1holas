using System.Globalization;
using System.IO;
using System.Reflection.PortableExecutable;

// Manejo de archivos
//Escribir un archivo

//Ruta relativa
string ruta = "archivo.txt";

//Proceso de escritua
using (StreamWriter writer = new StreamWriter(ruta))
{
    writer.WriteLine("Hola, este es un archivo de texto.");
    writer.WriteLine("Esta es otra linea de texto.");
}
Console.WriteLine("Archivo relativo escrito correctamente.");


//Ruta absoluta
string rutaA = @"C:\Users\carli\OneDrive\Documentos\Tecnicas de Programacion\Program3\archivo2.txt"; //Aqui le cambias w

//Proceso de escritura en la ruta absoluta
using (StreamWriter writer = new StreamWriter(rutaA))
{
    writer.WriteLine("Esto esta en un archivo con ruta absoluta");
    writer.WriteLine("Lo que sea.");
}
Console.WriteLine("Archivo absoluto escrito correctamente.");


//Proceso de lectura

string rutaLectura = rutaA;
using (StreamReader reader = new StreamReader(rutaLectura))
{ 
    string contenido = reader.ReadToEnd();
    Console.WriteLine("Contenido del archivo:");
    Console.WriteLine(contenido);
}

//Archivo binario escritura

string rutaB = "dato.bin";
//Proceso de escritura binaria
using (BinaryWriter writer = new BinaryWriter(File.Open(rutaB, FileMode.Create)))
{
    writer.Write(25);
    writer.Write(3.14);
    writer.Write("Texto binario");
}
Console.WriteLine("Archivo binario escrito correctamente");


//Lectura del archivo binario

using (BinaryReader reader = new BinaryReader(File.Open(rutaB, FileMode.Open)))
{
    /*int numero = reader.ReadInt32();
    double numeroDecimal = reader.ReadDouble();
    string texto = reader.ReadString();

    Console.WriteLine($"Entero: {numero}, Decimal: {numeroDecimal}, Texto: {texto}");*/
    var contenido = reader.Read();
    Console.WriteLine($"Salida: {contenido}");
}
Console.WriteLine("Archivo binario leido correctamente");

//Acceso secuencial
string rutaSecuencial = "archivoS.txt";

//Proceso de escritua
using (StreamWriter writer = new StreamWriter(rutaSecuencial))
{
    for (int i = 1; i <= 5; i++)
    {
        writer.WriteLine($"Linea {i}");
    }

}
Console.WriteLine("Archivo secuencial escrito correctamente.");


using (StreamReader reader = new StreamReader(rutaSecuencial))
{
    string linea;
    while ((linea = reader.ReadLine()) != null)
    {
        Console.WriteLine(linea);
    }
}

//Acceso aleatorio
string rutaAleatorio = "archivoA.txt";

//Proceso de escritura
using (FileStream fs = new FileStream(rutaAleatorio, FileMode.Create, FileAccess.ReadWrite))
{
    using (StreamWriter writer = new StreamWriter (fs))
    {
        writer.WriteLine("Primera linea");
        writer.WriteLine("Segunda linea");
        writer.WriteLine("Tercera linea");
    }
}

//Proceso de lectura aleatoria
using (FileStream fs = new FileStream(rutaAleatorio, FileMode.Open, FileAccess.Read))
{
    fs.Seek(8, SeekOrigin.Begin);
    using (StreamReader reader = new StreamReader(fs))
    {
        string linea = reader.ReadLine();
        Console.WriteLine("Lectura aleatoria: " + linea);
    }
}