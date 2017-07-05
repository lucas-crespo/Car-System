using System;
using System.Globalization;


namespace curso {
    class Tela {
        // Classe responsável por conter iteraçãoes com o usuário.
        public static void mostraMenu() {

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
        
        public static void cadastraCarros() {
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
        /*
        public static void cadastrarFilme() {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme F = new Filme(codigo, titulo, ano);
            Console.Write("Quantas participaçoes tem o Filme: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Digite os dados do " + i + "° item:");
                Console.Write("Artista (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = Program.artista.FindIndex(x => x.codigo == codProduto);
                if (pos == -1) {
                    throw new ModelException("Código de produto não encontrado: " + codProduto);
                }
                
                Console.Write("Porcentagem de desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao P= new Participacao( desconto, F, Program.artista[pos]);
                F.participacoes.Add(P);
            }
            Program.filme.Add(F);
        }
        
        public static void mostraFilme() {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.filme.FindIndex(x => x.codigo == codPedido);
            if (pos == -1) {
                throw new ModelException("Código de pedido não encontrado: " + codPedido);
            }
            Console.WriteLine(Program.filme[pos]);
            Console.WriteLine();
            Console.WriteLine();
        }
        */
    }
}
