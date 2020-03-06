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
        public void Cadastrar(EstudiosDomain estudios)
        {
             ctx.Estudios.Add(estudios);

        }
    }
}
