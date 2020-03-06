using Microsoft.AspNetCore.Mvc;
using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains;
using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Interfaces;
using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// AQUI É ONDE EU FAÇO ACONTECER
// O CACHORRO MORDE MEMO 
namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class EstudiosController : ControllerBase
    {
        private IEstudiosRepository _estudiosRepository { get; set; }
        public EstudiosController()
        {
            _estudiosRepository = new EstudiosRepository();
        }
        [HttpGet]
         

        public IEnumerable<EstudiosDomain> Listar()
        {
            return _estudiosRepository.ListarEstudios();
        }

        [HttpPost]

        public IActionResult Cadastrar(EstudiosDomain Estudio)
        {
            try
            {
                EstudiosRepository.Cadastrar(Estudio);
                return Ok("foooooooooooooooooooooooooi");

            }
            catch (Exception e)
            {
                return BadRequest(e);
                    }
        }
    }
}
