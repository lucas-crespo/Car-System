using System;
using System.Collections.Generic;


namespace curso {
    class Program {

        public static List<Marca> marcas = new List<Marca>();
        public static List<Carro> carros = new List<Carro>();
        //public static List<Acessorio> acessorio;// = new List<Acessorio>();
        static void Main(string[] args) {

            int selecao = 0;
            Marca M1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca M2 = new Marca(1002, "General Motors", "Estados Unidos");

            Carro c1 = new Carro (101, "Fusca",1980, 5000.00, M1);
            M1.addCarro(c1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, M1);
            M1.addCarro(c2);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, M1);
            M1.addCarro(c3);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, M2);
            M2.addCarro(c4);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, M2);
            M2.addCarro(c5);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000.00, M2);
            M2.addCarro(c6);
            carros.Sort();

            //Adicionando as marcas e carros nas listas locais do programa
            marcas.Add(M1);
            marcas.Add(M2);
            carros.Add(c1);
            carros.Add(c2);
            carros.Add(c3);
            carros.Add(c4);
            carros.Add(c5);
            carros.Add(c6);

            while (selecao != 7) {
                Console.Clear();
                Tela.mostrarMenu();
                try {
                    selecao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    selecao = 0;
                }
                Console.WriteLine();

                if (selecao == 1) {
                    Tela.mostrarMarcas();
                }
                else if (selecao == 2) {
                    Tela.mostrarCarrosDeUmaMarca();
                }
                else if (selecao == 3) {
                    try {
                        Tela.cadastrarMarcas();
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (selecao == 4) {
                    try {
                        Tela.cadastrarCarros();
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (selecao == 5) {
                    try {
                        Tela.cadastrarAcessorios();
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (selecao == 6) {
                    try {
                        Tela.mostrarDetalhes(carros);
                    }
                    catch (ModelException e) {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e) {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (selecao == 7) {
                    Console.WriteLine("Fim do programa!");
                }
                else {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
