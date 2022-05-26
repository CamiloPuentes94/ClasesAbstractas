using System;

namespace ClasesAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagartija pepito = new Lagartija("Copito");
            
            pepito.Respirar();
            pepito.GetNombre();
            
            
        }
    }
}