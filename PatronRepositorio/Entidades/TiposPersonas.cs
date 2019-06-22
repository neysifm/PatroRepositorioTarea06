using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class TiposPersonas
    {
        [Key]
        public int TipoPersonaId { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }

        public TiposPersonas()
        {
            TipoPersonaId = 0;
            IdPersona = 0;
            Nombre = string.Empty;
        }
    }
}
