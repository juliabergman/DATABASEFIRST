﻿using System;
using System.Collections.Generic;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains
{
    public partial class JogosDomain
    {
        public int IdJogo { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public int? Valor { get; set; }
        public int? IdEstudio { get; set; }

        public EstudiosDomain IdEstudioNavigation { get; set; }
    }
}
