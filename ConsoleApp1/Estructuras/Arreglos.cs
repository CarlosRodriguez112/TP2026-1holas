//Declaracion 
//Tipo [] nombre;

//Creacion e inicializacion

int[] numeros = new int[5];
string[] palabras = new string[3] { "Hola", "Mundo", "Adios" };

//Acceso a elementos
int primerNumero = numeros[0];
palabras[1] = "Universo";

//Array multidimensional

//MAtriz 2D (Filas x Columnas)
int[,] matriz = new int[3,3]; 
int[,] matrizInicializada =  { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

//Acceso

int valor = matrizInicializada[1, 2];

Console.WriteLine(valor);

//Arreglo de arreglos Jagged Array

//Arreglo de 3 elementos

int[][] jaggedArray = new int[3][];

//Asignar elementos
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6 }; 

//Acceso
for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine("Fila: " +i + " ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}