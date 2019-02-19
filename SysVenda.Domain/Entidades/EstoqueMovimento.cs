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
                
        public double QuantidadeEntrada { get; set; }

        public double QuantidadeSaida { get; set; }

        public int ProdutoId { get; set; }
        
        public Produto Produto { get; set; }
    }
}
