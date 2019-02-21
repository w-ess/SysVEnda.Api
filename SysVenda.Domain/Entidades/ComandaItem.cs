using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("COMANDAS_ITENS")]
    public class ComandaItem
    {
        [Key]
        public int Codigo { get; set; }

        // FK Comanda
        public int ComandaCd { get; set; }

        [ForeignKey("ComandaCd")]
        public Comanda Comanda { get; set; }

        // FK Produto
        public int ProdutoCd { get; set; }

        [ForeignKey("ProdutoCd")]
        public Produto Produto { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Valor { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Quantidade { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Desconto { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal ValorTotalLiquido { get; set; }
    }
}
