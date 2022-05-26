using System;

namespace ClasesAbstracta
{
    public class Caballo: Mamiferos, IMamiferisTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {

        public Caballo(string nombre) : base(nombre)
        {
            
        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferisTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas() => 2;

        public string TipoDeporte()
        {
            return "Deporte de saltar";
        }

        public bool EsOlimpico()
        {
            return true;
        }
    }
}