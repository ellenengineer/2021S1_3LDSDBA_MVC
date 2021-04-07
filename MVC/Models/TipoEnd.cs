using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Models
{
    public partial class TipoEnd
    {
        public TipoEnd()
        {
            Enderecos = new HashSet<Endereco>();
        }

        public int CodTipoEnd { get; set; }
        public string NomeTipoEnd { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
