using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        [Display (Name ="Nome do medicamento")]
        public String NomeMedicamento { get; set; }

        [Required]
        [Display(Name ="Quantidade do medicamento")]
        public int QtdeMedicamennto { get; set; }

        [Required]
        [Display(Name ="Codigo do Cliente")]
        public int CodCliente { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public int DataEntrega { get; set; }
    }

}
