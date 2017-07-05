using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso {
    class Acessorio {

        public double preco { get; set; }
        public string descricao { get; set; }
        public Carro carro;

        public Acessorio(string descricao, double preco, Carro carro) {
            this.descricao = descricao;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString() {          
            return "Acessórios: " + "\n" 
                + descricao
                + ", " 
                + "Preço: " 
                + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
