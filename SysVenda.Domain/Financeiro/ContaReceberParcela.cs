using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Financeiro
{
    [Table("CONTAS_RECEBER_PARCELAS")]
    public class ContaReceberParcela
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
        public int ContaReceberCd { get; set; }

        [ForeignKey("ContaReceberCd")]
        public ContaReceber ContaReceber { get; set; }
    }
}
