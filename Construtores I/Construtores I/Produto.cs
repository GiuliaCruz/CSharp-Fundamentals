using System;
using System.Globalization;

namespace Construtores_I {
    class Produto {
        public string Nome;
        public double Preço;
        public int Quantidade; 

        public double ValorTotalEmEstoque() {
            return Preço * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return Nome
                + ", $ "
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
             
        }
    }
}