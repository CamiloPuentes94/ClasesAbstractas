using System;

namespace ClasesAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Babieca");
            ISaltoConPatas ImiBabieca = miCaballo;
            Humano Camilo = new Humano();
            Gorila copito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = Camilo;
            almacenAnimales[2] = copito;

            for (int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamiferos miMamifero = new Mamiferos("");

            miMamifero.respirar();

            Ballena wally = new Ballena("Wally");
            wally.nadar();

            Console.WriteLine("Patas utilizadas en el saltode babieca: " + ImiBabieca.numeroPatas());

        }
    }
}