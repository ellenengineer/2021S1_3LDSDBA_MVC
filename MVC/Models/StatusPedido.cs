﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Models
{
    public partial class StatusPedido
    {
        public StatusPedido()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public short CodSta { get; set; }
        public string StaPed { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
