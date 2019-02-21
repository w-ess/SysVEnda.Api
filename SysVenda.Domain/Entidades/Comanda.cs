using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("COMANDAS")]
    public class Comanda
    {
        [Key]
        public int Codigo { get; set; }
        
        public DateTime DataHora { get; set; }

        public char? Status { get; set; }

        // FK Garcom
        public int GarcomCd { get; set; }

        [ForeignKey("GarcomCd")]
        public Garcom Garcom { get; set; }

        // FK Mesa
        public int MesaCd { get; set; }

        [ForeignKey("MesaCd")]
        public Mesa Mesa { get; set; }

        // FK Forma de Pagamento
        public int FormaPagamentoCd { get; set; }

        [ForeignKey("FormaPagamentoCd")]
        public FormaPagamento FormaPagamento { get; set; }
    }
}
