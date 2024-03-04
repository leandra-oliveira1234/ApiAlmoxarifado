using APIAlmoxarifado.NovaPasta1;

namespace ApiAlmoxarifado.Repository
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();
        void add(Produto produto);

        
        

        
    }
}
