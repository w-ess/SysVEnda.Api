using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Financeiro
{
    [Table("CONTAS_PAGAR_PARCELAS")]
    public class ContaPagarParcela
    {
        [Key]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Titulo { get; set; }

        public int Parcela { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Valor { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Juros { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Multa { get; set; }

        // Fk Conta Pagar //
        public int ContaPagarCd { get; set; }

        [ForeignKey("ContaPagarCd")]
        public ContaPagar ContaPagar { get; set; }
    }
}
