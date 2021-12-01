using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Business
{
    public class Cliente
    {
        public static List<Cliente> Busca()
        {
            var clientes = new List<Cliente>();
            var dados = Database.Cliente.Buscar();
            foreach (DataRow row in dados.Rows)
            {
                var cliente = new Cliente();
                cliente.Id = int.Parse(row["idCliente"].ToString());
                cliente.Nome = row["Nome"].ToString();
                clientes.Add(cliente);
            }
            return clientes;
        }

        public static Cliente BuscaPorId(int id)
        {
            var dados = Database.Cliente.BuscaPorId(id);
            var cliente = new Cliente();
            foreach(DataRow row in dados.Rows)
            {
                cliente.Id = int.Parse(row["idCliente"].ToString());
                cliente.Nome = row["Nome"].ToString();
            }
            return cliente;
        }
    }
}
