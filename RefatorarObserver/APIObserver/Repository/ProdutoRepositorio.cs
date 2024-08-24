using RefatorarObserver.Models;

namespace APIObserver.Repository
{
    public class ProdutoRepositorio
    {
        Context _context;

        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Produto> GetProdutos()
        {
            return _context.Produto.ToList();
        }

        public void updateProduto(Produto produto)
        {
            _context.Produto.Update(produto);
            _context.SaveChanges();
        }
    }
}
