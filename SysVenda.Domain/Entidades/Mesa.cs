using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("MESAS")]
    public class Mesa
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Descricao { get; set; }
    }
}
