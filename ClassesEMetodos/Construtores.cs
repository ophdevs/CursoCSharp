using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string Fabricante, int ano)
        {
            Modelo = modelo;
            this.Fabricante = Fabricante; // o this é necessário para diferenciar o campo da classe do parametro do construtor, ambos tem o mesmo nome -ph
            Ano = ano;
        }

        public Carro()
        {

        }
    }
    class Construtores
    {
        public static void Executar()
        {
            // formas de criar um objeto usando construtores

            var carro1 = new Carro();
            carro1.Fabricante = "Chevrolet";
            carro1.Modelo = "Astra";
            carro1.Ano = 2009;
            Console.WriteLine($"{carro1.Modelo}  {carro1.Fabricante} {carro1.Ano}");

            var carro2 = new Carro("Corsa", "Chevrolet", 2005); 
            Console.WriteLine($"{carro2.Modelo}  {carro2.Fabricante}  {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Palio",
                Ano = 2010
            };


            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
            
        }
    }
}
