using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1302
{
    public class Carro
    {
        //Características - Propriedades/Atributos
        public string? marca;
        public string? modelo;
        public int ano;
        public string? cor;
        public string? placa;
        public bool flex;

        //Ações - Métodos

        public void ligarCarro()
        {
            Console.WriteLine("O carro está ligado!");
        }

        public void desligarCarro()
        {
            Console.WriteLine("O carro está desligado!");
        }

        public void acelerarCarro()
        {
            Console.WriteLine("Carro acelerando...");
        }

        public void frearCarro()
        {
            Console.WriteLine("Carro freiando");
        }

        public void mostrarDetalhesCarro()
        {
            Console.WriteLine("Informe os dados do carro");

            Console.WriteLine("Modelo: ");
            modelo = Console.ReadLine();

            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();

            Console.WriteLine("Ano: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Placa: ");
            placa = Console.ReadLine();

            Console.WriteLine("Cor: ");
            cor = Console.ReadLine();

            Console.WriteLine("-------Dados do Carro-------");
            Console.WriteLine(modelo);
            Console.WriteLine(marca);
            Console.WriteLine(ano);
            Console.WriteLine(placa);
            Console.WriteLine(cor);
            Console.WriteLine("----------------------------");

        }
    }
}
