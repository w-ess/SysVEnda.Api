using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public Boolean Bloqueado { get; set; }
    }
}
