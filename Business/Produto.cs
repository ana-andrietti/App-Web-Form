using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public double Valor;
        public int IdFornecedor;
        public Fornecedor fornecedor;

        public Fornecedor Fornecedor
        {
            get
            {
                if (fornecedor != null) return fornecedor;
                fornecedor = Fornecedor.BuscaPorId(this.IdFornecedor);
                return fornecedor;
            }
        }

        public static List<Produto> BuscaPorPedidoId(int idPedido)
        {
            var pedidos = new List<Produto>();
            var dados = Database.Produto.BuscarPorPedidoId(idPedido);
            foreach (DataRow row in dados.Rows)
            {
                var pedido = new Produto();
                pedido.Id = int.Parse(row["idProduto"].ToString());
            }
        }   
    }
}
