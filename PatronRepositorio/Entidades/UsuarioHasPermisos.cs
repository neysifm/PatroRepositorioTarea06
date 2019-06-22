using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class UsuarioHasPermisos
    {
        [Key]
        public int IdUsuarioHasPermiso { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public UsuarioHasPermisos()
        {
            IdUsuarioHasPermiso = 0;
            IdUsuario = 0;
            IdPermiso = 0;
        }
    }
}
