using APIObserver.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefatorarObserver.Models;
using System.Collections.ObjectModel;

namespace APIObserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        ProdutoRepositorio _rep;

        public ProdutoController(ProdutoRepositorio rep)
        {
            _rep = rep;
        }
        [HttpGet(Name = "ListarProdutos")]

        public List<Produto> listaProdutos()
        {
           return _rep.GetProdutos();
        }

        [HttpPost("AtualizarPrecosEmMassa")]
        public bool AtualizarPrecosEmMassa(decimal valor)
        {
            try
            {
                AumentarPreco aumentarPreco = new AumentarPreco();
                List<Produto> produtosAlterar = _rep.GetProdutos().Where(x => x.PermitirEmMassa == true).ToList();
                foreach (var item in produtosAlterar)
                {
                    aumentarPreco.add(item);
                }
                aumentarPreco.notify(valor);

                foreach (var item in produtosAlterar)
                {
                    _rep.updateProduto(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
