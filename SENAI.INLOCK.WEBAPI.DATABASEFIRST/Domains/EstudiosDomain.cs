using System;
using System.Collections.Generic;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains
{
    public partial class EstudiosDomain
    {
        public EstudiosDomain()
        {
            Jogos = new HashSet<JogosDomain>();
        }

        public int IdEstudio { get; set; }
        public string NomeEstudio { get; set; }

        public ICollection<JogosDomain> Jogos { get; set; }
    }
}
