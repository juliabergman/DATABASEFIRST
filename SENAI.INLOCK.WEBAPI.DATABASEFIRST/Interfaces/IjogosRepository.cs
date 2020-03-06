using SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Interfaces
{
    interface IjogosRepository
    {
        List<JogosDomain> ListarJogos();
    }
}
