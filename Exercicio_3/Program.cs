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


            Console.WriteLine(marcas[1]);
            Console.WriteLine(carros[0]);
            Console.ReadLine();

            while (selecao != 5) {
                Console.Clear();
                Tela.mostraMenu();
                //selecao = int.Parse(Console.ReadLine());
                try {
                    selecao = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.Write("Erro inesperado: " + e.Message);
                    selecao = 0;
                }
                if (selecao == 1) {
                    Tela.mostrarMarcas();
                }
                Console.ReadLine();
            }
        }
    }
}
