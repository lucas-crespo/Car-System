using System;
using System.Globalization;
using System.Collections.Generic;


namespace curso {
    class Tela {
        // Classe responsável por conter iteraçãoes com o usuário.
        public static void mostrarMenu() {

            Console.WriteLine("1 - Listas marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar marca");
            Console.WriteLine("4 - Cadastar carro");
            Console.WriteLine("5 - Cadastar acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
            Console.Write("Digite uma opção: ");

        }
        
        public static void mostrarMarcas() {
            Console.WriteLine("\nLISTAGEM DE MARCAS");
            for (int i = 0; i < Program.marcas.Count ; i++) {
                Console.WriteLine(Program.marcas[i].ToString());
            }
        }
        
        public static void cadastrarCarros() {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (Código): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1) {
                throw new ModelException("Código não cadastrado: " + codMarca);
            }
            Console.Write("Código carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasico = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carro A = new Carro(codCarro, modelo, ano, precoBasico, Program.marcas[pos]);
            Program.carros.Add(A);
            Program.marcas[pos].addCarro(A);            
        }
        
        public static void cadastrarMarcas() {
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("País: ");
            string pais = Console.ReadLine();
            Marca M = new Marca(codigo, nome, pais);
            Program.marcas.Add(M);
        }
        public static void cadastrarAcessorios() {
            Console.WriteLine("Digite os dados do acessorio: ");
            Console.Write("Carro (Código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carros.FindIndex(x => x.codigo == codCarro);
            if (pos == -1) {
                throw new ModelException("Código não cadastrado: " + codCarro);
            }
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());         
            Acessorio A = new Acessorio( descricao, preco,Program.carros[pos]);
            Program.carros[pos].acessorios.Add(A);
        }
        public static void mostrarCarrosDeUmaMarca() {
            Console.WriteLine("Digite os dados da Marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marcas.FindIndex(x => x.codigo == codMarca);
            if (pos == -1) {
                throw new ModelException("Código não cadastrado: " + codMarca);
            }
            for (int i = 0; i < Program.marcas[pos].carros.Count; i++) {
                Console.Write(Program.marcas[pos].carros[i].ToString());
            }
        }

        public static void mostrarDetalhes( List<Carro> c) {
            Console.WriteLine("Digite o código do carro:");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = c.FindIndex(x => x.codigo == codCarro);
            if (pos == -1) {
                throw new ModelException("Código não cadastrado: " + codCarro);
            }
            Console.WriteLine(c[pos]);
            Console.WriteLine();
        }
    }
}
