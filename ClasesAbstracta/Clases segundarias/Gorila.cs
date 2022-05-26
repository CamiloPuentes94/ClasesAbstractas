﻿using System;

namespace ClasesAbstracta
{
    public class Gorila: Mamiferos, IMamiferisTerrestres
    {
        public Gorila(string nombre) : base(nombre)
        {
            
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int NumeroPatas() => 2;
    }
}