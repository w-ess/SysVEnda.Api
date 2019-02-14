using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoVenda { get; set; }
        
    }
}
