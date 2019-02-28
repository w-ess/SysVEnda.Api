using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Financeiro
{
    [Table("CONTAS_PAGAMENTOS")]
    public class ContaPagamento
    {
        [Key]
        public int Codigo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataCadastro { get; set; }

        public DateTime Data { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Valor { get; set; }

        // Fk CONTAS_RECEBER_PARCELAS//
        public int ContaPagarParcelaCd { get; set; }

        [ForeignKey("ContaPagarParcelaCd")]
        public ContaPagarParcela ContaPagarParcela { get; set; }
    }
}
