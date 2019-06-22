using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class TiposComprobantes
    {
        [Key]
        public int IdComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TiposComprobantes()
        {
            IdComprobante = 0;
            NombreComprobante = string.Empty;
        }
    }
}
