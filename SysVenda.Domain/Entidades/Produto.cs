using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("PRODUTOS")]
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(45)")]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal PrecoVenda { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string UnidadeMedida { get; set; }        
    }
}
