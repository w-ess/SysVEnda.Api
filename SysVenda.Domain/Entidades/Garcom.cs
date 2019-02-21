using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("GARCONS")]
    public class Garcom
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string Nome { get; set; }
    }
}
