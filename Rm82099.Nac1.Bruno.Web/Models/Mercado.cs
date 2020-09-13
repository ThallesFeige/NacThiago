using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rm82099.Nac1.Bruno.Web.Models
{
    [Table("Tbl_Mercado")]
    public class Mercado
    {
        [HiddenInput, Column("Id")]
        public int MercadoId { get; set; }

        [Column("Nome"), MaxLength(60), Required]
        public string Nome { get; set; }

        [Column("Capacidade")]
        public int Capacidade { get; set; }

        [Display(Name = "O mercado é novo?"), Column("Novo")]
        public bool Novo { get; set; }

        [Column("Porte")]
        public Porte Porte { get; set; }

        [Display(Name = "Data de Abertura"), DataType(DataType.Date), Column("DataAbertura")]
        public DateTime DataAbertura { get; set; }


    }
}
