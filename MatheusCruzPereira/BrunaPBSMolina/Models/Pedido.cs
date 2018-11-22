using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrunaPBSMolina.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public String NomeMedicamento { get; set; }
        public int QtdeMedicamennto { get; set; }
        public int CodCliente { get; set; }
        public int DataEntrega { get; set; }
    }
}