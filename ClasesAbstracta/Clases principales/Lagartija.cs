using System;

namespace ClasesAbstracta
{
    public class Lagartija: Animales
    {
        private string nombreReptil;
        
        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del reptil es: {nombreReptil} ");
        }
    }
}