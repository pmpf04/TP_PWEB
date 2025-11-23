using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Backend.Data.Entidades
{
    public class Encomenda
    {
        public int Id { get; set; }
        public DateTime DataEncomenda { get; set; } = DateTime.UtcNow;
        public bool EstaPaga { get; set; } = false;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public string ClienteId { get; set; } = string.Empty;
        public ApplicationUser Cliente { get; set; } = null!;

        public ICollection<DetalheEncomenda> Itens { get; set; } = new List<DetalheEncomenda>();
    }

    public class DetalheEncomenda
    {
        public int Id { get; set; }
        public int EncomendaId { get; set; }
        public Encomenda Encomenda { get; set; } = null!;

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoUnitario { get; set; }
    }
}
