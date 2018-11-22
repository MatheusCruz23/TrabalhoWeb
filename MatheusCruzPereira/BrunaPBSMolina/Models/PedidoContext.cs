using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrunaPBSMolina.Models
{
    public class PedidoContext : DbContext
    {
        DbSet<Pedido> pedido;
        public System.Data.Entity.DbSet<BrunaPBSMolina.Models.Pedido> Pedidoes { get; set; }
        public IQueryable<Pedido> Pedidos { get; internal set; }
    }
}