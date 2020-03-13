using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains;
using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//aqui vou dizer como as coisas vão acontecer
// não precisa mais usar a conexão com o SQL aqui pq tem uma pastinha escrito "context" e ela já
//faz todo o trabalho 
//ENTÃO
//vamos agora
namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {

        //o context vai emprestar os dados (como se fosse um lápis) pro  estudios
        //portanto, como é emprestado, então tem o nome dele
        // isso no literal fica assim:

            
        InLockContext ctx = new InLockContext();
        //dando um apelido a pasta context 
        // CTX É O CONTEXT !!!!!!!!!!!!!!!!!!!!!!

            //aqui eu to mostrando como a lista vai ser executada 
        public List<EstudiosDomain> ListarEstudios()
        {

            //usando o ctx
            return ctx.Estudios.ToList();
            //aqui nesta belíssima linha de merda
            //está dizendo que o CTX vai me emprestar os dados do SQL 
            // PRA RETORNAR A LISTA !!!!!!!!!!! 
        }


       // PARAMETRO:é quando vc vai comprar um prato no restaurante e 
       //nele tem arroz e feijão mais os acompanhamentos do prato
       // O PARAMETRO seria o acompanhamento
       //ou seja
       // parametro = pure de batata. NÃO PODE FALTAR!


            // objeto é tipo uma varíavel?
        public void Cadastrar(EstudiosDomain estudios)
        {
             ctx.Estudios.Add(estudios);
            ctx.SaveChanges();

        }   

        public void Atualizar(EstudiosDomain estudiosAtualizados)
        {
            // nesse linha a gente tá procurando o id que a gente fez no corpo da requisição
            //ele vai procurar no banco os dados
            //SE ELE ACHAR, ELE VAI
            //armazenar nesse ctx
            // e o ctx vai se armazevar no var pacotes
            //corpo da requisição == isso aqui no body do postman ó:
            //{
            //                          "idpacotes" : 1
            //                       }

            var estudios = ctx.Estudios.First(e => e.IdEstudio == estudiosAtualizados.IdEstudio);
            estudios.NomeEstudio = estudiosAtualizados.NomeEstudio;

            // agora vou passar os atributos

            estudios.NomeEstudio = estudiosAtualizados.NomeEstudio;
            ctx.SaveChanges();

        }

        //public void Deletar(EstudiosDomain estudioBuscado)
        //{
        //   //Estudios estudioBuscado = ctx.Estudios.Find(id);

        //    ctx.Estudios.Remove(estudioBuscado);
        //    ctx.SaveChanges();
        //}

        public void BuscarPorId(int id)
        {
            // Retorna o primeiro estúdio encontrado para o ID informado
             ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }
    }
}
