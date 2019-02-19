﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("PRODUTOS")]
    public class Produto
    {
        [Key]
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoVenda { get; set; }

        public decimal UnidadeMedida { get; set; }
        
    }
}