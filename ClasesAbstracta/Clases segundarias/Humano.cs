using System;

namespace ClasesAbstracta
{
    public class Humano: Mamiferos
    {
        public Humano(string nombre) : base(nombre)
        {
            
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de llevar mas alla el pensamiento");
        }
    }
}