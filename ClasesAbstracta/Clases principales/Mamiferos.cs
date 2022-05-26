using System;

namespace ClasesAbstracta
{
    public class Mamiferos: Animales
    {
        // Variables de la clase
        private string nombreSerVivo;
        
        // constructor
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        
        //  metodo para poliformismo
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del Mamifero es: {nombreSerVivo} ");
        }
        
    }
}