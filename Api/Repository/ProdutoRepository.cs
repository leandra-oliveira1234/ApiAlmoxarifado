using ApiAlmoxarifado.Infraestrutura;
using ApiAlmoxarifado.Repository;
using APIAlmoxarifado.NovaPasta1;
using Microsoft.AspNetCore.Mvc;

namespace APIAlmoxarifado.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        ConexaoSQL bdConexao = new ConexaoSQL();
        public void add(Produto produto)
        {
            bdConexao.Add(produto);
            bdConexao.SaveChanges();
        }
        public List<Produto> GetAll()
        {
            return bdConexao.Produto.Tolist();
        }
    }
}


    


