using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;
        private string observacao;

        public long Id_Pedido { get => id_pedido; set => id_pedido = value; }
        public DateTime DataHoraPedido { get => datahorapedido; set => datahorapedido = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        internal Aparelho Aparelho { get => aparelho; set => aparelho = value; }
    }
}
