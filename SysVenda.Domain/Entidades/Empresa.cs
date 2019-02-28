using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("EMPRESAS")]
    public class Empresa
    {
        [Key]
        public int Codigo { get; set; }        

        public int PessoaCd { get; set; }

        [ForeignKey("PessoaCd")]
        public Pessoa Pessoa { get; set; }
    }
}
