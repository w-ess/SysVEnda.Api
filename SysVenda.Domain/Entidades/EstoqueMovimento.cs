using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("ESTOQUE_MOVIMENTO")]
    public class EstoqueMovimento
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal QuantidadeEntrada { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal QuantidadeSaida { get; set; }
        
        public int ProdutoCd { get; set; }

        [ForeignKey("ProdutoCd")]
        public Produto Produto { get; set; }
    }
}
