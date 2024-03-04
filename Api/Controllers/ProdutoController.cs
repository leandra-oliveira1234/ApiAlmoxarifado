using ApiAlmoxarifado.Repository;
using ApiAlmoxarifado.ViewModel;
using APIAlmoxarifado.NovaPasta1;
using APIAlmoxarifado.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Ok("Hello Mundo");
        }

        [HttpGet]
        [Route("GetAllFake")]
        public IActionResult GetAllFake()
        {
            var produtos = new List<Produto>();
            {
                new Produto()
                {
                    id = 1,
                    nome = "PC HP",
                    estoque = 10
                };
                new Produto()
                {
                    id = 2,
                    nome = "PC DELL",
                    estoque = 20
                };
            };
            return Ok(produtos);

        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_produtoRepository.GetAll());
        }

        [HttpPost]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoSemFoto(ProdutoViewModeSemFoto produto)
        {
            try
            {
                _produtoRepository.Add
                (
                new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }

        [HttpPost]
        [Route("AdicionarProdutoSemFoto")]
        public IActionResult AdicionarProdutoComFoto([FromForm] ProdutoViewModeSemFoto produto)
        {
            try
            {
                _produtoRepository.Add
                (
                new Produto() { nome = produto.nome, estoque = produto.estoque, photourl = null }
                );

                return Ok("Cadastrado com Sucesso");
            }
            catch (Exception ex)
            {

                return BadRequest("Não Cadastrado. Erro" + ex.Message);
            }

        }
        [HttpPost]
        [Route("{id}/GetProduto")]

        public IActionResult GetProduto(int id)
        {
            return Ok(_produtoRepository.GetAll().Find(x => x.id == id));

        }


    }

}



