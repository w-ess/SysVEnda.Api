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

        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Login { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Senha { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }
        
        public char? Tipo { get; set; }

        public Boolean Bloqueado { get; set; }
    }
}
