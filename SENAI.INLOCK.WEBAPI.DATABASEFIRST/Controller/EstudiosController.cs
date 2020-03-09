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
    // Isso aqui não pode faltar. É a ligação com o postman! como se fosse uma conexão wifi
    //sem wifi, ele não recebe a mensagem.
    [Produces("application/json")]
    [Route("api/[controller]")]

    [ApiController]
    public class EstudiosController : ControllerBase
                                       // o ControllerBase não pode faltar também, ele é como adotar uma gatinha prenha
                                       //os filhotinhos fazem parte do pacote
    {
        private IEstudiosRepository _estudiosRepository { get; set; }
        //pq aqui é declarado privado?
        //só nesse controller ele é usavel
        // basicamente: ele tá casado aqui e não pode ir de gracinha pra outros lugares. Ele é privado e acabo.

        public EstudiosController()
        {
            _estudiosRepository = new EstudiosRepository();
            //basicamente um apelido pra não ter que ficar chamando ele pelo nome o tempo inteiro 
        }
        [HttpGet]
        //O FAMOSO ENDPOINT
        //ele é como se fosse um aviso pro computador
        // "EI. É PRA FAZER UM GET AQUI", "GET, VEM AQUI, CARA!!"
         

        public IEnumerable<EstudiosDomain> Listar()
        {
            return _estudiosRepository.ListarEstudios();
        }

        [HttpPost]
        //tentando entender oq aconteceu aqui
        //bom, aqui vai ser realizado o cadastro 
        //vai ser de modo público
        public IActionResult Cadastrar(EstudiosDomain Estudio)
                                       //aqui tá dando um apelido pri EstudiosDomain
        // Pq eu to usando o IActionResult?
        //ele serve pra dar vários tipos de retorno,
        //  como o "return BadRequest"
        // basicamete, é como se ele fosse mais receptivo na hora de dar o retorno
        // ele é "mente aberta", mas não aceita TODOS, só alguns.

        {

        // Pq eu to usando try e catch?
        //BOm, eles são feitos pra casos de exceções
        //OU SEJA
        //se der merda, eles vão ser um plano B pra identificar esse problema
            try
            {
                _estudiosRepository.Cadastrar(Estudio);
                return Ok("foooooooooooooooooooooooooi");

            }
            //se der ruim, retorna BadRequest
            catch (Exception e)
            {
                return BadRequest(e);
                    }
        }
        [HttpGet]

        public IActionResult Listar(EstudiosDomain Estudio)
        {
           
        }
    }
}
