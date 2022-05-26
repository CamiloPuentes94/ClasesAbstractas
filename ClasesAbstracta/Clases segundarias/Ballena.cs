using System;

namespace ClasesAbstracta
{
    public class Ballena: Mamiferos
    {
        // constructor de ballena heredando nombre descrito en el constructor de Mamiferos
        public Ballena(string nombre) : base(nombre)
        {
            
        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}