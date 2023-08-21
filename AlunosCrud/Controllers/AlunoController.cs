using AlunosCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlunosCrud.Controllers
{
    [ApiController]
    public class AlunoController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Create(Aluno aluno)
        {
           return Ok(aluno);
        }

        [HttpPut]
        public ActionResult Edit(Aluno aluno)
        {    
             return Ok(aluno);  
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
        
    }
}
