using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SysVenda.Domain.Entidades;

namespace SysVenda.Domain.Financeiro
{
    [Table("CONTAS_RECEBER")]
    public class ContaReceber
    {
        [Key]
        public int Codigo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataCadastro { get; set; }

        public DateTime Data { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Observacao { get; set; }

        // Fk Pessoa//
        public int PagadorCd { get; set; }

        [ForeignKey("PagadorCd")]
        public Pessoa Pagador { get; set; }

        public List<ContaReceberParcela> ContasPagarParcelas { get; set; }
    }
}
