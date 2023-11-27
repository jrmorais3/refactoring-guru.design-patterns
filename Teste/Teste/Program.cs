﻿using Builder1.ConcreteBuilder;
using Builder1.Director;
using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaria = new Pizzaria(new PizzaCalabreza());
            pizzaria.MontaPizza();
            var pizza1 = pizzaria.GetPizza();
            pizza1.PizzaConteudo();

            pizzaria = new Pizzaria(new PizzaMussarela());
            pizzaria.MontaPizza();
            var pizza2 = pizzaria.GetPizza();
            pizza2.PizzaConteudo();

            Console.ReadKey();
        }
    }
}
