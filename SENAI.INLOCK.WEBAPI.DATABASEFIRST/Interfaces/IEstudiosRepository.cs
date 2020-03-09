using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Interfaces
{
    interface IEstudiosRepository
    {
      List<EstudiosDomain> ListarEstudios();


        // cadastrando os EstudiosDomain, da lista EstudiosDomain dando o apelido estudios 
        void Cadastrar(EstudiosDomain estudios);

        void Listar(int id, EstudiosDomain estudios);
    }
}
