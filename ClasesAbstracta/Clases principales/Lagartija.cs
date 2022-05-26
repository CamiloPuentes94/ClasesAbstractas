using System;

namespace ClasesAbstracta
{
    public class Lagartija: Animales
    {
        private string nombreReptil;

        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }
        
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil} ");
        }
    }
}