using CShape_WebAPIA01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CShape_WebAPIA01.Controllers
{
    [Route("api/funcionarios")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly Funcionario[] Funcionarios = new Funcionario[]
        {
            new Funcionario
            {
                Codigo = 1,
                Nome = "Renato",
                Sobrenome = "Silva",
                Setor = "TI",
                Cidade = "Recife"
            },
            new Funcionario
            {
                Codigo = 2,
                Nome = "Catarina",
                Sobrenome = "Rodrigues",
                Setor = "RH",
                Cidade = "Olinda"
            },
            new Funcionario
            {
                Codigo = 3,
                Nome = "Julio",
                Sobrenome = "Coelho",
                Setor = "ADM",
                Cidade = "Paulista"
            },
            new Funcionario
            {
                Codigo = 4,
                Nome = "Fabiana",
                Sobrenome = "Moura",
                Setor = "Patrimônio",
                Cidade = "Jaboatão dos Guararapes"
            },
        };

        // GET api/funcionario
        [HttpGet]
        public Funcionario[] Get()
        {
            return Funcionarios;
        }

        // GET api/funcionario/5
        [HttpGet("{codigo}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/funcionario
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/funcionario/5
        [HttpPut("{codigo}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/funcionario/5
        [HttpDelete("{codigo}")]
        public void Delete(int id)
        {

        }     
    }
}
