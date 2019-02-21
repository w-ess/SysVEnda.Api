using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SysVenda.Domain.Entidades
{
    [Table("PESSOAS")]
    public class Pessoa
    {
        [Key]
        public int Codigo { get; set; }
        
        public char? Tipo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string RazaoSocialNome { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string NomeFantasiaApelido { get; set; }

        [Column(TypeName = "varchar(14)")]
        public string CnpjCpf { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Pais { get; set; }

        [Column(TypeName = "varchar(2)")]
        public string Estado { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Cidade { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string Cep { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Bairro { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Endereco { get; set; }

        [Column(TypeName = "varchar(8)")]
        public string Numero { get; set; }

        public List<Pessoa> Pessoas { get; set; }
    }
}
