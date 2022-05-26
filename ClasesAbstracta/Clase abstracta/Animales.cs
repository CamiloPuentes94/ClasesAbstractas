using System;

namespace ClasesAbstracta
{
    public abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        // metodo abstracto  para GetNombre
        public abstract void GetNombre();

    }
}