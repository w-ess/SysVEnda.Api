using Microsoft.EntityFrameworkCore.Infrastructure;
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
        private Mesa _mesa;
        private FormaPagamento _formaPagamento;
        private Garcom _garcom;

        private Comanda(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        private ILazyLoader LazyLoader { get; set; }


        [Key]
        public int Codigo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DataHora { get; set; }

        public char? Status { get; set; }

        // FK Garcom
        public int GarcomCd { get; set; }

        [ForeignKey("GarcomCd")]        
        public Garcom Garcom
        {
            get => LazyLoader.Load(this, ref _garcom);
            set => _garcom = value;
        }

        // FK Mesa
        public int MesaCd { get; set; }

        [ForeignKey("MesaCd")]        
        public Mesa Mesa
        {
            get => LazyLoader.Load(this, ref _mesa);
            set => _mesa = value;
        }

        // FK Forma de Pagamento
        public int FormaPagamentoCd { get; set; }

        [ForeignKey("FormaPagamentoCd")]        
        public FormaPagamento FormaPagamento
        {
            get => LazyLoader.Load(this, ref _formaPagamento);
            set => _formaPagamento = value;
        }
    }
}
