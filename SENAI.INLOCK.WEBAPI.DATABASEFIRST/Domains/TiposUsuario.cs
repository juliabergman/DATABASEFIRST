using System;
using System.Collections.Generic;

namespace SENAI.INLOCK.WEBAPI.DATABASEFIRST.Domains
{
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoUsuario { get; set; }
        public string Titulo { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
